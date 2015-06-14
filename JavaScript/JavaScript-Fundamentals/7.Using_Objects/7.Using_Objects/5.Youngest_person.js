var output = '';
var people = [
{ firstname: 'Gosho', lastname: 'Petrov', age: 32 },
{ firstname: 'Bay', lastname: 'Ivan', age: 81 },
{ firstname: 'Mosho', lastname: 'Ivanov', age: 33 },
{ firstname: 'Tosho', lastname: 'Petrovchev', age: 35 }
];

output += 'people properties = ' + Object.keys(people[0]) + '<br />';
people.forEach(function (person) {
    output += 'person values = ' + Object.keys(person).map(function (key) {
        return person[key];
    }) + '<br />';;
});
output += '&nbsp; Youngest person is: ' + youngest(people) + '<br />';

if (document.getElementById('Youngest_person') != null) document.getElementById('Youngest_person').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function youngest(arrOfPeople) {
    var youngestPerson = arrOfPeople[0] || undefined;
    arrOfPeople.forEach(function (person) {
        if (person['firstname'] == undefined || person['lastname'] == undefined || person['age'] == undefined) {
            return "This is not a person class. Missing properties!";
        }
        if (person.age < youngestPerson.age) {
            youngestPerson = person
        }
    })
    return (youngestPerson.firstname + ' ' + youngestPerson.lastname);
}

