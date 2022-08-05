
function init() {
    var button = document.getElementById("addButton");
    button.onclick = heandleButtonClick;
}

function heandleButtonClick() {

    var textInput = document.getElementById("songTextInput");
    var getSong = textInput.value;

    if (getSong.trim() != "") {

        var li = document.createElement("li");
        li.innerHTML = getSong;
        var ul = document.getElementById("playlist");
        ul.appendChild(li);

    }
    else {
        alert("Please, enter a song!");
    }
}

window.onload = init;

