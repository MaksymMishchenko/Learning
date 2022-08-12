var map = null;
var watchId = null;
var prevCoords = null;

var ourCoords = {
    latitude: 47.624851,
    longitude: -122.52099
};

var options = { enableHighAccuracy: true, timeout: 5000, maximumAge: 90000 };

window.onload = getMyLocation;

function getMyLocation() {
    if (navigator.geolocation) {
        //navigator.geolocation.getCurrentPosition(showMyLocation, displayError);
        watchButton = document.getElementById("watch");
        watchButton.onclick = watchLocation;

        clearWatchButton = document.getElementById("clearWatch");
        clearWatchButton.onclick = clearWatch;
    } else {
        alert("Something went wrong");
    }
}

function watchLocation() {
    watchId = navigator.geolocation.watchPosition(showMyLocation, displayError, options);
}

function clearWatch() {
    if (watchId) {
        navigator.geolocation.clearWatch(watchId);
        watchId = null;
    }
}

function showMyLocation(position) {
    var pos = position.coords;
    var latitude = pos.latitude;
    var longitude = pos.longitude;

    var div = document.getElementById("location");
    div.innerHTML = "Latitude: " + latitude + ", Longitude: " + longitude;
    div.innerHTML += " with " + pos.accuracy + " meters accuracy";

    var km = computeDistance(position.coords, ourCoords);
    var distance = document.getElementById("distance");
    distance.innerHTML = "You are " + km + " km from the WickedlySmart HQ";

    if (map == null) {
        showMap(pos);
        prevCoords = pos;
    } else {
        var meters = computeDistance(pos, prevCoords) * 1000;
        if (meters > 20) {
            scrollMapToPosition(pos);
            prevCoords = pos;
        }

    }

    div.innerHTML += "(found in " + options.timeout + " milliseconds)";
}

function displayError(error) {

    errorsType = ["Unknown error", "Permission denied by user", "Position is not available", "Request timed out"];

    var errorMessage = errorsType[error.code];

    if (error.code == 0 || error.code == 2) {
        errorMessage = errorMessage + " " + error.message;
    }

    var div = document.getElementById("location");
    div.innerHTML = errorMessage;

    options.timeout += 100;
    navigator.geolocation.getCurrentPosition(showMyLocation, displayError, options);
    div.innerHTML += "... cheking again with timeout=" + options.timeout;
}

function computeDistance(startCoords, destCoords) {
    var startLatRads = degreesToRadians(startCoords.latitude);
    var startLongRads = degreesToRadians(startCoords.longitude);

    var destLatRads = degreesToRadians(destCoords.latitude);
    var destLongRads = degreesToRadians(destCoords.longitude);

    var Radius = 6371; // Earth radius
    var distance = Math.acos(Math.sin(startLatRads) * Math.sin(destLatRads) +
        Math.cos(startLatRads) * Math.cos(destLatRads) *
        Math.cos(startLongRads - destLongRads)) * Radius;

    return distance;
}

function degreesToRadians(degrees) {
    var radians = (degrees * Math.PI) / 180;
    return radians;
}

function showMap(coords) {

    var googleLatAndLong = new google.maps.LatLng(coords.latitude, coords.longitude);

    var mapOptions = {
        zoom: 10,
        center: googleLatAndLong,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };

    var mapDiv = document.getElementById("map");
    map = new google.maps.Map(mapDiv, mapOptions);

    var title = "Your Location";
    var content = "You are here: " + coords.latitude + ", " + coords.longitude;

    addMarker(map, googleLatAndLong, title, content);
}

function addMarker(map, latlong, title, content) {

    markerOptions = {
        position: latlong,
        map: map,
        title: title,
        clickable: true
    };

    infoWindowOptions = {
        content: content,
        position: latlong
    };

    var mapMarker = new google.maps.Marker(markerOptions);

    var infoWindow = new google.maps.InfoWindow(infoWindowOptions);

    google.maps.event.addListener(mapMarker, "click", function () {
        infoWindow.open(map);
    });
}

function scrollMapToPosition(coords) {
    var latitude = coords.latitude;
    var longitude = coords.longitude;

    var latAndLong = new google.maps.LatLng(latitude, longitude);

    map.panTo(latAndLong);

    addMarker(map, latAndLong, "Your new location", "You moved to: " + latitude + ", " + longitude);
}





