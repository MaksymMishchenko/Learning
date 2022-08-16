var position = 0;
var playlist;
var video;

window.onload = function () {
	playlist = ["video/areyoupopular", "video/destinationearth"];
	video = document.getElementById("video");
	video.addEventListener("ended", nextVideo, false);
	video.src = playlist[position] + getFormatExtensions();
	video.load();
	video.play();
}

function nextVideo() {
	position++;
	if (position >= playlist.length) {
		position = 0;
	}
	video.src = playlist[position] + getFormatExtensions();
	video.load();
	video.play();
}

function getFormatExtensions() {
	if (video.canPlayType("video/mp4") != "") {
		return ".mp4";
	}

	if (video.canPlayType("video/webm") != "") {
		return ".webm";
	}

	if (video.canPlayType("video/ogg") != "") {
		return ".ogv";
	}
}