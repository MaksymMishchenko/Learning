window.onload = function () {

    var button = document.getElementById("previewButton");
    button.onclick = previewHandler;
}

function previewHandler() {
    var canvas = document.getElementById("tShirtCanvas");
    var context = canvas.getContext("2d");

    var selectObject = document.getElementById("shape");
    var index = selectObject.selectedIndex;
    var shape = selectObject[index].value;
    fillBackgroundColor(canvas, context);

    if (shape == "square") {
        for (var square = 0; square < 20; square++) {
            drawSquares(canvas, context);
        }
    } else if (shape == "circle") {
        for (var circle = 0; circle < 20; circle++) {
            drawCircle(canvas, context);
        }
    }
}

function drawSquares(canvas, context) {
    var w = Math.floor(Math.random() * 40);

    var x = Math.floor(Math.random() * canvas.width);
    var y = Math.floor(Math.random() * canvas.height);

    context.fillStyle = "lightblue";
    context.fillRect(x, y, w, w);
}

function drawCircle(canvas, context) {

    var radius = Math.floor(Math.random() * 40);
    var x = Math.floor(Math.random() * canvas.width);
    var y = Math.floor(Math.random() * canvas.height);

    context.beginPath();
    context.arc(x, y, radius, degreesToRadian(360), 0, true);
    context.fillStyle = "lightblue";
    context.fill();
}

function fillBackgroundColor(canvas, context) {
    var selectObject = document.getElementById("backgroundColor");
    var index = selectObject.selectedIndex;
    var backgroundColor = selectObject[index].value;
    context.fillStyle = backgroundColor;
    context.fillRect(0, 0, canvas.width, canvas.height);
}

function degreesToRadian(degrees) {
    return (degrees * Math.PI) / 180;
}