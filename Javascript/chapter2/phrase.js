function makePhrases() {

    var words1 = ["24/7", "multi-Tier", "30,000 foot", "B-to-B", "win-win"];
    var words2 = ["empowered", "value-added", "oriented", "focused", "aligned"];
    var words3 = ["process", "solution", "tipping-point", "strategy", "vision"];

    var rand1 = Math.floor(Math.random() * words1.length);
    var rand2 = Math.floor(Math.random() * words1.length);
    var rand3 = Math.floor(Math.random() * words1.length);

    var phrase = words1[rand1] + " " + words2[rand2] + " " + words3[rand3];

    var phraseElement = document.getElementById("phrase");

    phraseElement.innerHTML = phrase;
}

window.onload = makePhrases;