window.onload = function () {
    var button = document.getElementById("button");
    button.onclick = handleButtonClick;
}

function handleButtonClick() {
    var inputWeight = document.getElementById("inputWeight");
    var weight = inputWeight.value;

    var inputName = document.getElementById("inputName");
    var name = inputName.value;

    alert(bark(name, weight));
}

var bark = function (dogName, dogWeight) {

    if (dogWeight <= 10) {
        return dogName + " says Yip";
    }
    else {
        return dogName + " says Woof";
    }
}

