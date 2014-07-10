function sort(col, order){
	url='php/ajax.php?function=sort&sortcol=' + col + '&sortorder=' + order;
	YAHOO.util.Connect.asyncRequest('GET', url, {success:receiveAjaxCallbackHandler,argument: {  },timeout:50000});
}

function displayTopic(topic){
	url='php/ajax.php?function=topic&topic=' + topic;
	YAHOO.util.Connect.asyncRequest('GET', url, {success:receiveAjaxCallbackHandler,argument: {  },timeout:50000});
}

function post(topic){
	url='php/ajax.php?function=post&topic=' + topic + '&comment=' + document.getElementById('comments').value;
	YAHOO.util.Connect.asyncRequest('GET', url, {success:receiveAjaxCallbackHandler,argument: {  },timeout:50000});
}

function displayList(){
	url='php/ajax.php';
	YAHOO.util.Connect.asyncRequest('GET', url, {success:receiveAjaxCallbackHandler,argument: {  },timeout:50000});
}

function receiveAjaxCallbackHandler(o){
	try{
		var root = o.responseXML.documentElement;
		document.getElementById('body').innerHTML = root.firstChild.nodeValue;
	}catch(e){
		alert("Error: " + e);
	}
}