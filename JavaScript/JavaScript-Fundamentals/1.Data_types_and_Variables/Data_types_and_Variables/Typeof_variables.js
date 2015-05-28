//var array = ['a', 'b', 'c'],
//boolean = true,
//integer = 1,
//float = 1.5,
//object = { objectColor: "green" },
//string = "green";

var output = 'typeof(boolean) = ' + typeof (boolean) + '<br />'
    + 'typeof(array) = ' + typeof(array) + '<br />'
    + 'typeof(integer) = ' + typeof(integer) + '<br />'
    + 'typeof(float) = ' + typeof(float) + '<br />'
    + 'typeof(object) = ' + typeof(object) + '<br />'
    + 'typeof(string) = ' + typeof(string) + '<br />';
document.getElementById('Typeof_variables').innerHTML += output;
console.log(output.replace(/<br \/>/gi, "\n"));