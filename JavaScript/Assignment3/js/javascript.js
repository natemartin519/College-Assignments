// Nathan Martin
// JavaScript
// Assignment 3


var timer1 = window.setInterval('intervalMove("movingAd1")', 500);
var timer2 = window.setTimeout('timeoutMove("movingAd2")', 500);


function moveRight(inObject){
	var refToObject = document.getElementById(inObject);
	var left = '';
	var tempLeft = 0;

	if(refToObject.style.left == ''){
		refToObject.style.left = "0px";
	}else{
		left = refToObject.style.left;
		left = left.split("px");
		tempLeft = new Number(left[0]);
		tempLeft = tempLeft + 10;		
		left = tempLeft + "px";
		refToObject.style.left = left;
	}  
	
	return tempLeft;
}


function intervalMove(inObject){
	if (moveRight(inObject) >= 500){
		timer1 = window.clearInterval(timer1);
	}	
}


function timeoutMove(inObject){
	if (moveRight(inObject) < 500){
		timer2 = window.setTimeout('timeoutMove("movingAd2")', 500);
	}	
}