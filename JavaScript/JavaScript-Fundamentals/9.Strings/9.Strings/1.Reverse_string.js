var output = '', input = 'sample', result;

result = reverse(input);

output += 'input = ' + input + '<br />';
output += 'result = ' + result + '<br />';

if (document.getElementById('Reverse_string') != null) document.getElementById('Reverse_string').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));


function reverse(input) {
    return input.split('').reverse().join('');
}