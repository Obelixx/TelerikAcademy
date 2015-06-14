var output = '', input = [256, 123.45, -204, 'hi5', '-65.3444'];

input.forEach(function (value) {
    output += 'input = ' + value + '<br />' + '&nbsp; reuslt = ' + reverseNumber(value) + '<br />';
})

if (document.getElementById('Reverse_number') != null) document.getElementById('Reverse_number').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function reverseNumber(int) {
    var minus = false, result;
    if (!parseFloat(int)) return 'not a number';
    if (int < 0) {
        int = -int;
        minus = true;
    }
    result = parseFloat(int.toString().split('').reverse().join(''));
    if (minus) result = -result;
    return result;
}