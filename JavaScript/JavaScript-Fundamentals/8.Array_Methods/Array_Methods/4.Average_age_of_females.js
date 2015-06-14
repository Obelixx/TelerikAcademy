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

output += 'Average_age_of_females is: ' + avrAgeOfF(pplArr) + '<br />';

if (document.getElementById('Average_age_of_females') != null) document.getElementById('Average_age_of_females').innerHTML += output;
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

function avrAgeOfF(pplArr) {
    var females = pplArr.filter(function (person) { return person.gender });
    var count = females.length;
    var ageSum = 0;
    females.forEach(function (female) { ageSum += female.age });
    return ((ageSum / count) | 0);
}