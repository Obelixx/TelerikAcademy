var output = '', text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.",
    string = 'in', result;

result = subString(text, string);
output += 'text = ' + text + '<br />';
output += 'string = ' + string + '<br />';
output += '&nbsp; result = ' + result + '<br />';

if (document.getElementById('Substring_in_text') != null) document.getElementById('Substring_in_text').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function subString(text, string) {
    return text.match(RegExp(string, 'gi')).length;
}