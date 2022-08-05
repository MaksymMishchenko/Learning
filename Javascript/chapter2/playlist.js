function addSongs() {
    var getSong1 = document.getElementById("song1");
    getSong1.innerHTML = "Blue Suede Strings, by Elvis Pagely";

    var getSong2 = document.getElementById("song2");
    getSong2.innerHTML = "Great Objects on Fire, by Jerry JSON Lewis";

    var getSong3 = document.getElementById("song3");
    getSong3.innerHTML = "I Code the Line, by Johnny JavaScript";
}

window.onload = addSongs;