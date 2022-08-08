window.onload = init;

function init() {
    var button = document.getElementById("button");
    button.onclick = handleButtonClick;
}

function handleButtonClick() {
    var getWeight = document.getElementById("inputWeight");
    var value = getWeight.value;
    alert(bark("bark", value));
}

function bark(dogName, dogWeight) {

    if (dogWeight <= 10) {
        return dogName + " says Yip";
    }
    else {
        return dogName + " says Woof";
    }
}

