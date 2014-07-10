// Nathan Martin
// JavaScript
// Assignment 4

var timer = new Array();
var refToObject;


function init(){
	openMenu = GetCookie();
	
	if (openMenu){
		ShowSubMenu(parseInt(openMenu));
	}
}


function ShowSubMenu(inNum){

	// clear timer if set
	if(timer[inNum]){
		window.clearTimeout(timer[inNum]);
		timer[inNum] = null;
	}

	// display menu
	switch (inNum){
	case 1:
		refToObject = document.getElementById("SubMenuOne");
		break;
	case 2:
		refToObject = document.getElementById("SubMenuTwo");
		break;
	case 3:
		refToObject = document.getElementById("SubMenuThree");
		break;
	default:
		return;
	}
	
	refToObject.style.display = "inline";	
	
	SetCookie(inNum);
}


function StartCloseTimer(inNum){

	switch (inNum){
	case 1:
		timer[inNum] = window.setTimeout('HideSubMenu("SubMenuOne")', 3000);
		break;
	case 2:
		timer[inNum] = window.setTimeout('HideSubMenu("SubMenuTwo")', 3000);
		break;
	case 3:
		timer[inNum] = window.setTimeout('HideSubMenu("SubMenuThree")', 3000);
		break;
	}
}


function HideSubMenu(inMenu){
	// hide menu
	refToObject = document.getElementById(inMenu);
	refToObject.style.display = "none";	
	
	// cleanup
	refToObject = null;
}


function SetCookie(inValue){
	var date = new Date();
	date.setDate(date.getDate() + 1);

	document.cookie = "Menu=" + escape (inValue) + "; expires=" + date.toUTCString();
}


// unsave cookie grab
function GetCookie(){
	var theCookie = document.cookie;

	if (theCookie.length > 0){
		return theCookie.substring(5, theCookie.length);
	}else{
		return null;
	}
}