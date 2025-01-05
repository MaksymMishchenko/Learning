
function Movie(title, genre, rating, showTimes) {
	this.title = title;
	this.genre = genre;
	this.rating = rating;
	this.showTimes = showTimes;
	this.getNextShowing = function () {
		var now = new Date().getTime();
		for (var i = 0; i < this.showTimes.length; i++) {

			var showtime = this.method(this.showTimes[i]);

			if ((showtime - now) > 0) {
				return "Next showing of " + this.title + " is " + this.showTimes[i];
			}
		}
		return null;
	};
	this.method = function getTimeFromString(str) {
		var theTime = new Date();
		var time = str.match(/(\d+)(?::(\d\d))?\s*(p?)/);
		theTime.setHours(parseInt(time[1]) + (time[3] ? 12 : 0));
		theTime.setMinutes(parseInt(time[2]) || 0);
		return theTime.getTime();
	} 
}

var banzaiMovie = new Movie("Buckaroo Banzai", "Cult Classic", 5, ["1:00pm", "5:00pm", "7:00pm", "11:00pm"]);
alert(banzaiMovie.getNextShowing());

var movie1 = new Movie("Plan 9 from Outer Space", "Plan 9 from Outer Space", 2, ["3:00pm", "7:00pm", "11:00pm"]);
alert(movie1.getNextShowing());

var movie2 = new Movie("Forbidden Planet", "Classic Sci-fi", 2, ["5:00pm", "9:00pm"]);
alert(movie2.getNextShowing());