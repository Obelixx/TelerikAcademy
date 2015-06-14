var output = '', input = [512, 124, 1239, 0, -2, 'hi', 'hi5', '65'];

input.forEach(function(value) {
    output += 'input = ' + value + '<br />' + '&nbsp; reuslt = ' + lastDigiInInt_AsWord(value) + '<br />';
})

if (document.getElementById('English_digit') != null) document.getElementById('English_digit').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function lastDigiInInt_AsWord(int) {
    var result, digit = int;
    if (digit < 0) digit = -digit;
    digit = parseInt(digit % 10);
    switch (digit) {
        case 0:
            result = 'zero';
            break;
        case 1:
            result = 'one';
            break;
        case 2:
            result = 'two';
            break;
        case 3:
            result = 'three';
            break;
        case 4:
            result = 'four';
            break;
        case 5:
            result = 'five';
            break;
        case 6:
            result = 'six';
            break;
        case 7:
            result = 'seven';
            break;
        case 8:
            result = 'eight';
            break;
        case 9:
            result = 'nine';
            break;
        default:
            result = 'not a number';
            break;
    }
    return result;
}