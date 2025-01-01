function showTemperature() {
    var tempArray = new Array();
    tempArray[0] = 59.3;
    tempArray[1] = 60.1;
    tempArray[2] = 61.5;
    tempArray[3] = 62.8;
    tempArray[4] = 58.3;

    for (let index = 0; index < tempArray.length; index++) {

        const theTemp = tempArray[index];

        const id = "temp" + index;

        const li = document.getElementById(id);

        if (index == 0) {
            li.innerHTML = "The temperature at noon was " + theTemp + "F";
        }
        else {
            li.innerHTML = "The temperature at " + index + " was " + theTemp;
        }
    }
}

window.onload = showTemperature;