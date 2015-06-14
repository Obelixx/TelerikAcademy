var output = '', text = "a a  a   a    a";


output += 'text befor = ' + text + '<br />';
output += 'text after = ' + safe_text(text) + '<br />';


if (document.getElementById('nbsp') != null) document.getElementById('nbsp').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function safe_text(str) {
    return str.replace(RegExp(' ', 'gi'), '&nbsp;'); 
}