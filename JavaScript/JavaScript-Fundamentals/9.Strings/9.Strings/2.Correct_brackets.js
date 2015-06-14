var output = '', input1 = '((a+b)/5-d)', input2 = ')(a+b))', result;

result = checkBrackets(input1);
output += 'input1 = ' + input1 + '<br />';
output += '&nbsp; input1 - ' + result + '<br />';
result = checkBrackets(input2);
output += 'input2 = ' + input2 + '<br />';
output += '&nbsp; input2 - ' + result + '<br />';

if (document.getElementById('Correct_brackets') != null) document.getElementById('Correct_brackets').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function checkBrackets(expression) {
    var brackets = 0,char;
    for (char in expression) {
        if (expression[char] == '(') {
            brackets++;
        }
        if (expression[char] == ')') {
            brackets--;
        }
        if (brackets < 0) {
            return false;
        }
    }
    if (brackets == 0) {
        return true;
    } else return false;
}