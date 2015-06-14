var output = '', pplArr = [], reduced = [];

//polyfill array.reduce
if (!Array.prototype.reduce) {
    Array.prototype.reduce = function (callback /*, initialValue*/) {
        'use strict';
        if (this == null) {
            throw new TypeError('Array.prototype.reduce called on null or undefined');
        }
        if (typeof callback !== 'function') {
            throw new TypeError(callback + ' is not a function');
        }
        var t = Object(this), len = t.length >>> 0, k = 0, value;
        if (arguments.length == 2) {
            value = arguments[1];
        } else {
            while (k < len && !(k in t)) {
                k++;
            }
            if (k >= len) {
                throw new TypeError('Reduce of empty array with no initial value');
            }
            value = t[k++];
        }
        for (; k < len; k++) {
            if (k in t) {
                value = callback(value, t[k], k, t);
            }
        }
        return value;
    };
}

pplArr = [
    makePerson('Ivan', 'Petkov', 23, false),
    makePerson('Petko', 'Petrov', 18, false),
    makePerson('Petyr', 'Soinov', 40, false),
    makePerson('Stonio', 'Lolov', 10, false),
    makePerson('Filo', 'Chelov', 28, false),
    makePerson('Chelio', 'Shishov', 22, false),
    makePerson('Shisho', 'Bakshishov', 65, false),
    makePerson('Bakshishka', 'Totkova', 25, true),
    makePerson('Botka', 'Fotkova', 28, true),
    makePerson('Fotka', 'Aparatova', 22, true),
    makePerson('SNqkoj', 'Neizvesten', 17, false)
];

reduced = pplArr.reduce(function (personObj, item) {

    if (personObj[item.firstname[0]]) {
        personObj[item.firstname[0]].push(item);
    } else {
        personObj[item.firstname[0]] = [item];
    }
    return personObj;
}, {});

output += 'reduced = ' + reduced + '<br />';
output += 'better explore this result in console, by typeing: reduced' + '<br />';

if (document.getElementById('Group_people') != null) document.getElementById('Group_people').innerHTML += output;
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
