var output = '', pplArr = [];

//polyfill array.find
if (!Array.prototype.find) {
    Array.prototype.find = function (callback, thisArg) {
        "use strict";
        var arr = this,
            arrLen = arr.length,
            i;
        for (i = 0; i < arrLen; i += 1) {
            if (callback.call(thisArg, arr[i], i, arr)) {
                return arr[i];
            }
        }
        return undefined;
    };
}

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

output += 'Youngest male person is: ' + pplArr.find(function(male){return male.age === youngestAgeFromMales(pplArr);}) + '<br />';

if (document.getElementById('Youngest_person') != null) document.getElementById('Youngest_person').innerHTML += output;
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

function youngestAgeFromMales(pplArr) {
    var males = pplArr.filter(function (person) { return !person.gender });
    var youngestAge = males[0].age || undefined;
    males.forEach(function (male) {
        if (male.age < youngestAge) {
            youngestAge = male.age;
        }
    });
    return youngestAge;
}