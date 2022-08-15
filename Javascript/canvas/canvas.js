window.onload = function () {
    var button = document.getElementById("btn");
    button.onclick = handleCircle;
}

function handleCircle() {
    var canvas = document.getElementById("canvas");
    var context = canvas.getContext("2d");

    context.beginPath();
    context.moveTo(50, 75);
    context.lineTo(125, 33);
    context.lineTo(170, 80);
    context.lineTo(140, 120);
    context.lineTo(110, 120);
    context.closePath();
   

    context.lineWidth = 3;
    context.stroke();
    context.fillStyle = "red";
    context.fill();

    

}