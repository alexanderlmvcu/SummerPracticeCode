vap apiRootURL = 'http://voteapi.empower2018.us';

function bindClickevent () {
	$('#show-options').click(function() {
		$.get(apiRootURL + '/apis', function(data) {
			var optionData = '';
			for (var i=0; i< data.length; i++) {
				optionData += '<p>id: ' + data[i]._id + ' - name: ' + data.[i].name + '</p>';
			}
			$('#options-container').html(optionData);
		});
	});
	$('#show-tally').click(function () {
		$.get(apiRootURL + '/tally', function(data) {
			var optionData = '';
			for (var i = 0; i < data.length; i++) {
				optionData += '<p>name: ' + data[i].api_name + ": " + data[i].vote_count + '</p>';
			}
			$('#tally-container').html(optionData);
		});

	$('#do-vote').click(function () {
		$.post(apiRootURL + '/alexanderlmvcu/vote', {"api_name":$('#api_name').val()}, 
			function(data) {
				console.log(data);
			};
			});
	});
	$('#show-vote').click(function () {
		$.get(apiRootURL + 'alexanderlmvcu/vote', function(data) {
			$('#tally-container').html(optionData);
			console.log(vote);
		});
	});
	$('#reset-vote').click(function () {
		$.delete(apiRootURL + '/harper/vote', function(data) {
			console.log(data);
			// $.ajax ({
				// url: apiRootURL + 'harper/vote',
				// type: 'DELETE',
				// success: function(data) {
					// console.log(data);
				//},
				//};
				// $.ajax(options);
				//})
		});
	});

};