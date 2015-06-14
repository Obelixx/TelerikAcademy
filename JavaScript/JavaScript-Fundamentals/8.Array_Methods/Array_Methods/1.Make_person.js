var output = '', pplArr = [];

output += 'pplArr = ' + '<br />';
pplArr = [
    makePerson('Ivan', 'Petkov', 23, false),
    makePerson('Petko', 'Petrov', 18, false),
    makePerson('Petyr', 'Soinov', 40, false),
    makePerson('Stonio', 'Lolov', 25, false),
    makePerson('Lilo', 'Chelov', 28, false),
    makePerson('Chelio', 'Shishov', 22, false),
    makePerson('Shisho', 'Bakshishov', 65, false),
    makePerson('Bakshishka', 'Totkova', 25, true),
    makePerson('Totka', 'Fotkova', 28, true),
    makePerson('Fotka', 'Aparatova', 22, true)
];
pplArr.forEach(function (person) {
    output += '&nbsp' + person.toString() + '<br />';
})

if (document.getElementById('Make_person') != null) document.getElementById('Make_person').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));


function makePerson(firstname, lastname, age, gender) {
    var out;
    if (arguments.length != 4) { return 'Whong number of arguments!'; }
    if (typeof (firstname) !== typeof ('1') || typeof (lastname) !== typeof ('a') || typeof (age) !== typeof (20) || typeof (gender) !== typeof (true)) {
        return "Whrong data for person!";
    }
    return {
        firstname: firstname,
        lastname: lastname,
        age: age,
        gender: gender,
        toString: function () {
            gender ? out = 'f' : out = 'm';
            out = this.firstname + ' ' + this.lastname + ' (' + this.age + out + ')';
            return out;
        }
    }
}