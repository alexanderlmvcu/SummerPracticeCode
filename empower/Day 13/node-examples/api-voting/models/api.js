var mongoose = require('mongoose');
 var Schema = mongoose.Schema; 
 var Api = new Schema({     
 	name   : String }, 
 	{ collection: 'api' }); 
module.exports = mongoose.model('Api', Api); 