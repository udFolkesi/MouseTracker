let mouseData = [];

document.addEventListener("mousemove", (event) => {
    mouseData.push({ x: event.clientX, y: event.clientY, t: Date.now() });
});

document.getElementById("sendData").addEventListener("click", async () => {
    await fetch('/api/mouse', {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(mouseData)
    });
    alert("Данные отправлены!");
    mouseData = [];
});
