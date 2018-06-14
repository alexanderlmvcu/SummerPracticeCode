var apiURL = 'http://worldclockapi.com/api/json/est/now';
function bindClickevent () {
	$('#get-time').click(function() {
		getTimeWithAjax();
	});
};

function getTimeStringFromData(data) {
	return 'It is' + data.dayOfTheWeek + '. The time is ' + data.currentDateTime + '(' + data.TimeZone + ')'
};

function getTimeWithAjax() {
	$.ajax(apiURL, {
		method: 'GET'
	})
	.done(function(data) {
		console.log('got the data');
		console.log(data);
		$('#time-container').html(getTimeStringFromData(data));
	})
	.fail(function() {
		console.log('failure');
	})
	.always(function() {
		console.log('this always happens');
	});;
};

//this is the most straightforward one
function getTimeUsingGet () {
	$.get(apiURL, function(data){
	$('#time-container').html(getTimeStringFromData(data));	
	});
};