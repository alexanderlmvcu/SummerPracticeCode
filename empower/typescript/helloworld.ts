class Student {
    fullName: string;
    luckyNumber : number;
    isPresent:boolean;
    teams : string[];
}

function greeter(whoToGreet : Student){
    let dictionary = {
        "Greeting": "Hello",
        "Farewell": "Leave the premises immediately, sir"
    };

    return `${dictionary["Greeting"]} ${whoToGreet.fullName}`;
}

function showLuckyNumber(student : Student) {
    return `Lucky number is ${student.luckyNumber}`;
}
function showTeams (student: Student) {
    let teamList : string = "";
    
    for (let i = 0; i < student.teams.length; i++) {
        teamList += `<br/> ${student.teams[i]}`;
    }
    return teamList;
}

let me = new Student();


me.fullName = "Paul Taylor";
me.isPresent = true;
me.luckyNumber = 7;
me.teams = ["Southampton", "Hampshire"];

document.body.innerHTML = `<h1>${greeter(me)}</h1>`+ 
                        `<h2>${showLuckyNumber(me)}</h2>`+
                        `<p> ${showTeams(me)}</p>`;