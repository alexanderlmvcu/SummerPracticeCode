var mongoose = require('mongoose'); 
var Schema = mongoose.Schema; 
var Vote = new Schema({   
	voter_id: {     
		type: mongoose.Schema.Types.ObjectId,     
		ref: 'Voter'   },   
		api_id: {     
			type: mongoose.Schema.Types.ObjectId,     
			ref: 'Api'   } 
		}, 
			{ collection: 'vote' }); 
module.exports = mongoose.model('Vote', Vote);