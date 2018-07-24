var Student = /** @class */ (function () {
    function Student() {
    }
    return Student;
}());
function greeter(whoToGreet) {
    return "Hello" + whoToGreet.fullname;
}
var me = new Student();
me.fullname = "Paul Taylor";
document.body.innerHTML = greeter(me);
