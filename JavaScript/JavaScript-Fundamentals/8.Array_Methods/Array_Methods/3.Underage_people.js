var output = '', pplArr = [];

pplArr = [
    makePerson('Ivan', 'Petkov', 23, false),
    makePerson('Petko', 'Petrov', 18, false),
    makePerson('Petyr', 'Soinov', 40, false),
    makePerson('Stonio', 'Lolov', 10, false),
    makePerson('Lilo', 'Chelov', 28, false),
    makePerson('Chelio', 'Shishov', 22, false),
    makePerson('Shisho', 'Bakshishov', 65, false),
    makePerson('Bakshishka', 'Totkova', 25, true),
    makePerson('Totka', 'Fotkova', 28, true),
    makePerson('Fotka', 'Aparatova', 22, true),
    makePerson('Nqkoj', 'Neizvesten', 17, false)
];

output += 'underage are: ' + '<br />';
pplArr.filter(checkUnderage).forEach(function (person) {
    output += '&nbsp;' + person.toString() + '<br />';
})

if (document.getElementById('Underage_people') != null) document.getElementById('Underage_people').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function makePerson(firstname, lastname, age, gender) {
    var out;
    if (arguments.length != 4) { return 'Whong number of arguments!'; }
    if (typeof (firstname) !== typeof ('а') || typeof (lastname) !== typeof ('a') || typeof (age) !== typeof (20) || typeof (gender) !== typeof (true)) {
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

function checkAgeIs18_orGreater(pplArr) {
    var result = true;
    pplArr.forEach(checkAgeIs18_orGreater_forPerson)
    return result;
}

function checkAgeIs18_orGreater_forPerson(person) {
    return person.age >= 18;
}

function checkUnderage(person) {
    return !checkAgeIs18_orGreater_forPerson(person);
}