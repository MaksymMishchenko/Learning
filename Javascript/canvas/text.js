window.onload = function () {
var canvas = document.getElementById("canvas");
var context = canvas.getContext("2d");

context.beginPath();
context.moveTo(100, 100);
context.lineTo(250,100 );
context.stroke();

context.font = "italic bold 2em Lucida Grande";
context.textBaseline = "middle";
/* 
context.textBaseline = "top";
context.textBaseline = "hanging";
context.textBaseline = "alphabetic";
context.textBaseline = "ideographic";
context.textBaseline = "bottom";
*/ 
context.fillText("Alphabet", 100, 100);
}