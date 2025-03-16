using Moq;
using MouseTracker.Application.DTO;
using MouseTracker.Application.Services;
using MouseTracker.Domain.Entities;
using MouseTracker.Infrastructure.Repositories.Abstractions;
using System.Text.Json;

namespace MouseTrackerTests
{
    public class MouseTrackServiceTests
    {
        [Fact]
        public async Task SaveMovementAsync_SavesDataCorrectly()
        {
            var mockRepo = new Mock<IBaseRepository<MouseTrack>>();
            var service = new MouseTrackService(mockRepo.Object);

            var mouseMovements = new List<MouseMovementDto>
        {
            new(5, 10, DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()),
            new(20, 50, DateTimeOffset.UtcNow.ToUnixTimeMilliseconds())
        };

            MouseTrack? savedMouseTrack = null;

            mockRepo.Setup(repo => repo.AddAsync(It.IsAny<MouseTrack>()))
                    .Callback<MouseTrack>(m => savedMouseTrack = m);

            await service.SaveMouseTrackAsync(mouseMovements);

            Assert.NotNull(savedMouseTrack);
            var deserializedData = JsonSerializer.Deserialize<List<MouseMovementDto>>(savedMouseTrack!.Data);
            Assert.NotNull(deserializedData);
            Assert.Equal(mouseMovements.Count, deserializedData.Count);

            for (int i = 0; i < mouseMovements.Count; i++)
            {
                Assert.Equal(mouseMovements[i].X, deserializedData[i].X);
                Assert.Equal(mouseMovements[i].Y, deserializedData[i].Y);

                var timeDiff = Math.Abs(mouseMovements[i].T - deserializedData[i].T);
                Assert.InRange(timeDiff, 0, 100);
            }

            mockRepo.Verify(repo => repo.AddAsync(It.IsAny<MouseTrack>()), Times.Once);
        }
    }
}
