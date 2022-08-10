window.onload = getMyLocation;

function getMyLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showMyLocation, displayError);
    } else {
        alert("Something went wrong");
    }
}

function showMyLocation(position) {
    var pos = position.coords;
    var latitude = pos.latitude;
    var longitude = pos.longitude;

    var div = document.getElementById("location");
    div.innerHTML = "Latitude: " + latitude + ", Longtitude: " + longitude;
}

function displayError(error) {

    errorType = {
        0: "Unknown error",
        1: "Permission denied by user",
        2: "Position is not available",
        3: "Request timed out"
    };

    var errorMessage = errorType[error.code];

    if (error.code == 0 || error.code == 2) {
        errorMessage = errorMessage + " " + error.message;
    }

    var div = document.getElementById("location");
    div.innerHTML = errorMessage;

}