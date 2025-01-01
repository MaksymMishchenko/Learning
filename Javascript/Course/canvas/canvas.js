window.onload = function () {
    var button = document.getElementById("btn");
    button.onclick = handleCircle;
}

function handleCircle() {
    var canvas = document.getElementById("canvas");
    var context = canvas.getContext("2d");

    context.beginPath();
    /*
    context.moveTo(50, 75);
    context.lineTo(125, 33);
    context.lineTo(170, 80);
    context.lineTo(140, 120);
    context.lineTo(110, 120);
    //context.closePath();
    */
    context.arc(300, 100, 90, degreesToRadians(360), 0, true);
    context.lineWidth = 5;
    context.stroke();
    context.fillStyle = "yellow";
    context.fill();

    context.beginPath();
    context.arc(250, 85, 25, degreesToRadians(360), 0, true);
    context.stroke();

    context.beginPath();
    context.arc(350, 85, 25, degreesToRadians(360), 0, true);
    context.stroke();

    context.beginPath();
    context.moveTo(300, 105);
    context.lineTo(300, 130);
    context.stroke();

    context.beginPath();
    context.arc(300, 140, 35, degreesToRadians(180), 0, true );
    context.stroke();
}

function degreesToRadians(degrees) {
    return (degrees * Math.PI) / 180;
}