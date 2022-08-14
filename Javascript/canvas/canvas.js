window.onload = function () {
    var button = document.getElementById("btn");
    button.onclick = handleCircle;
}

function handleCircle() {
    var canvas = document.getElementById("canvas");
    var context = canvas.getContext("2d");

    context.arc(100, 100, 75, degreesToRadians(270), 0, true);

    context.lineWidth = 10;
    context.stroke();
    context.fillStyle = "red";
    context.fill();

}