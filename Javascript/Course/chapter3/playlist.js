window.onload = init;

function init() {
    var button = document.getElementById("addButton");
    button.onclick = handleButtonClick;
    loadPlaylist();  
}

function handleButtonClick(e) {

    var textInput = document.getElementById("songTextInput");
    var getSong = textInput.value;

    if (getSong.trim() != "") {

        var li = document.createElement("li");
        li.innerHTML = getSong;
        var ul = document.getElementById("playlist");
        ul.appendChild(li);
        save(getSong);
    }
    else {
        alert("Please, enter a song!");
    }
}

