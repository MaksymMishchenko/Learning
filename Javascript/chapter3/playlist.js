
window.onload = init;

function init() {
    var button = document.getElementById("addButton");
    button.onclick = heandleButtonClick;
}

function heandleButtonClick() {
    alert("Button was clicked");
}

