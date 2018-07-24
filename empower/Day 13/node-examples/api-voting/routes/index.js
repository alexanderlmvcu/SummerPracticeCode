var express = require('express'); 
var router = express.Router(); 
var Voter = require('../models/voter'); 
var Vote = require('../models/vote'); 
var Api = require('../models/api'); 
/* GET home page. */ 
router.get('/', function(req, res, next) {   
	res.render('index', { title: 'Express' });
	 }); 
function getApiById(api_list, api_id) {   
	for(var i=0; i<api_list.length; i++) {     
		if (api_id.equals(api_list[i].api_id)) {       
		return api_list[i];     
		}   
	}  
return null;
} 
// GET vote tally 
router.get('/tally', function(req, res, next) {   
	Vote.find().exec(function(err, votes) {     
		if (err) return next(err);     
		// first we group the results into a distinct list, counting votes for each api     
		var prettyResults = [];     
			for(var i=0; i<votes.length; i++) {       
				var witnessedApi = getApiById(prettyResults, votes[i].api_id);       
				if (witnessedApi === null) {         
					prettyResults.push({api_id: votes[i].api_id, vote_count: 1});       
				} else {             
					witnessedApi.vote_count++;
					 }     
					}     
					 // now lets loop through the distinct list and add the names of the apis to help it make sense to the end user
var promiseArray = prettyResults.map(tally_row => new Promise(function(resolve, reject) {           
	Api.findById(tally_row.api_id, function (err, api) {             
		if (err) return reject(err);             
		tally_row.api_name = api.name;             
		resolve(tally_row);           
				});         
			}));       
	Promise.all(promiseArray).then(function(results) {      
	res.json(results);       
		});            
	}); 
});
// GET vote tally 
router.get('/apis', function(req, res, next) {   
	Api.find().exec(function(err, apis) {     
		if (err) return next(err);     
		res.json(apis);   
	}); 
});
// GET user's vote
router.get('/:username/vote', function(req, res, next) {   
// find the referenced voter   
Voter.find({'username': req.params.username}).exec(function(err, voter) {       
	if (err) return next(err);       
	if (voter.length == 0) {         
		return res.json({             
			success: false,              
			message: "No voter with username " + req.params.username + " could be found!"        
			 });       
	}       
	// find the first vote recorded for this voter (should only be 1) 
	Vote.find({'voter_id': voter[0]._id}).exec(function(err, existing_votes) {         
	if (err) return next(err);         
	if (existing_votes.length == 0) {           
	return res.json({success: false, message: req.params.username + " has not yet voted."});         
	}         
	// go get the api record related to this vote         
	Api.findById(existing_votes[0].api_id, function (err, api) {           
	if (err) return next(err);           
	// return the vote information           
	return res.json({             
		success: true,              
		message: {               
			api_name: api.name,              
			voter_username: voter[0].username 
					}           
				});         
			});       
		});   
	}); 
});
// POST to save a user's vote 
// expects a json request specifying { api_name: "some-api" } 
router.post('/:username/vote', function(req, res, next) {   
	Api.find({'name': req.body.api_name}).exec(function(err, api) {       
		if (err) return next(err);       if (api.length == 0) {         
			return res.json({success: false, message: "No api named " + req.body.api_name + " could be found!"});       
		}       
		Voter.find({'username': req.params.username}).exec(function(err, voter) {         
			if (err) return next(err);         
			if (voter.length == 0) {             
				return res.json({               
					success: false,                
					message: "No voter with username " + req.params.username + " could be found!"             
				});         
			}
			Vote.find({'voter_id': voter[0]._id, 'api_id': api[0]._id}).exec(function(err, existing_votes) {             
			if (err) return next(err);             
			// only 1 vote per voter is allowed             
			if (existing_votes.length > 0) {               
			return res.json({                 
			success: false,                  
			message: req.params.username + " has already voted once!  Delete the vote in order to vote again if you like."               
			});           
			}           
			// record a new vote for this voter           
			var vote = {             
				voter_id: voter[0]._id,             
				api_id: api[0]._id           
			};             
			new Vote(vote).save(function (err) {               
				if (err) return next(err);               
				console.log('inserted');               
				res.json({success: true, message: "Vote recorded"});             
			});         
		});       
		});   
	}); 
});
// DELETE to remove a voter's vote 
router.delete('/:username/vote', function(req, res, next) {       
	Voter.find({'username': req.params.username}).exec(function(err, voter) {         
		if (err) return next(err);         
		if (voter.length == 0) {             
			return res.json({               
				success: false,                
				message: "No voter with username " + req.params.username + " could be found!"             
			});         
		}         
		Vote.find({'voter_id': voter[0]._id}).exec(function(err, existing_votes) {             
			if (err) return next(err); 
            if (existing_votes.length > 0) {               
            	Vote.findByIdAndRemove(existing_votes[0].id, (err, b) => {                   
            		if (err) return next(err);                 
            		console.log('removed ' + b._id);                 
            		res.json({success: true, message: "Vote removed"});               
            	});           
            } else {               
            	return res.json({                 
            		success: false,                  
            		message: "No existing vote exists to delete for "+ req.params.username +"."               
            	});           
            }         
        });       
	}); 
}); 
module.exports = router;