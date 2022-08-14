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

    if (shape == "square") {
        for (square = 0; square < 20; square++) {
            drawSquares(canvas, context);
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