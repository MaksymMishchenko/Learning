function save(item) {
    var playlistArray = getStoreArray("playlist");
    playlistArray.push(item);
    localStorage.setItem("playlist", JSON.stringify(playlistArray));
}

function loadPlaylist() {
    var playlistArray = getSavedSong();
    var ul = document.getElementById("playlist");

    if (playlistArray != null) {
        for (var index = 0; index < playlistArray.length; index++) {
            var li = document.createElement("li");
            li.innerHTML = playlistArray[index];
            ul.appendChild(li)
        }
    }
}

function getSavedSong() {
    return getStoreArray("playlist");
}

function getStoreArray(key) {
    var playlistArray = localStorage.getItem(key);
    if (playlistArray == null || playlistArray == "") {
        playlistArray = new Array();
    }
    else {
        playlistArray = JSON.parse(playlistArray);
    }
    return playlistArray;
}
