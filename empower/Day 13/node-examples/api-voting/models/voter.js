var mongoose = require('mongoose'); 
var Schema = mongoose.Schema; 
var Voter = new Schema({     
	first_name   : String,     
	last_name    : String,     
	username     : String }, 
	{ collection: 'voter' }); 
module.exports = mongoose.model('Voter', Voter);