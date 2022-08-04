var word1 = "a";
var word2 = "nam";
var word3 = "nal p";
var word4 = "lan a c";
var word5 = "a man a p";

var phrase = "";

for (var i = 0; i < 5; i++) {

    if (i == 0) {
        phrase = word5; // a man a p
    }

    else if (i == 1) {
        phrase = phrase + word4; // lan a c
    }

    else if (i == 2) {
        phrase = phrase + word1 + word3; // anal p
    }
    else if (i == 3) {
        phrase = phrase + word1 + word2 + word1;
    }

    else{
        alert("Undefined")
    }
}

alert(phrase);