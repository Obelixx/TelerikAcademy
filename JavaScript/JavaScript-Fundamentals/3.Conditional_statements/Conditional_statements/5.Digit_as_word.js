var n, result, len, output,
	digit = [2, 1, 0, 5, -0.1, 'hi', 9, 10];
for (n = 0, len = digit.length ; n < len ; n++) {
    switch (digit[n]) {
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
            result = 'not a digit';
            break;
    }
    output = 'digit = ' + digit[n] + '; result = ' + result + '<br />';
    if (document.getElementById('Digit_as_word') != null) document.getElementById('Digit_as_word').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}