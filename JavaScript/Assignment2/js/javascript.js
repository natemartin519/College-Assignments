// Nathan Martin
// JavaScript
// Assignment 2

function gotoPage(){
	var newLocation = prompt('Where do you want to go today?');
	document.location = newLocation;
}

function submitForm(inAction){

	document.theForm.action = inAction;
	document.theForm.submit();

}