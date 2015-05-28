var array = ['a', 'b', 'c'],
boolean = true,
integer = 1,
float = 1.5,
object = { objectColor: "green" },
string = "green";

var output = 'array = ' + array + '<br />'
    + 'boolean = ' + boolean + '<br />'
    + 'integer = ' + integer + '<br />'
    + 'float = ' + float + '<br />'
    + 'object = ' + object + '<br />'
    + 'string = ' + string + '<br />';
document.getElementById('JavaScript_literals').innerHTML += output;
console.log(output.replace(/<br \/>/gi, "\n"));