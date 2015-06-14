var output = '';
var people = [
{ firstname: 'Gosho', lastname: 'Petrov', age: 32 },
{ firstname: 'Bay', lastname: 'Ivan', age: 81 },
{ firstname: 'Mosho', lastname: 'Ivanov', age: 33 },
{ firstname: 'Tosho', lastname: 'Petrovchev', age: 35 }
];

var groupedByFname = group(people, 'firstname');
var groupedByAge = group(people, 'age');

if (document.getElementById('Groups_of_people') != null) document.getElementById('Groups_of_people').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function group(people, key) {
    return "no time for this task.. :/"
}