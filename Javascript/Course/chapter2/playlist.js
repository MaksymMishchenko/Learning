function addSongs() {
    var getSong1 = document.getElementById("song1");
    getSong1.innerHTML = "Blue Suede Strings, by Elvis Pagely";

    var getSong2 = document.getElementById("song2");
    getSong2.innerHTML = "Great Objects on Fire, by Jerry JSON Lewis";

    var getSong3 = document.getElementById("song3");
    getSong3.innerHTML = "I Code the Line, by Johnny JavaScript";
}

window.onload = addSongs;

var tempByFahrenheit = [59.2, 60.0, 61.3, 61.8, 59.6];

alert("The temperature at 5 was " + tempByFahrenheit[2] + "F");
alert("Array length is " + tempByFahrenheit.length + "elements");

