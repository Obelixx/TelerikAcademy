var i, result, nlen, output,
    n = [5, 701, 1732, 9703, 877, 777877, 9999799, 77,777],
    third_digit = 7;
for (i = 0, nlen = n.length; i < nlen; i++) {
    result = n[i].toString().split('').reverse().join('').charAt(2) === third_digit.toString();
    output = 'n = ' + n[i] + '; Third digit 7? - ' + result + '<br />';
    document.getElementById('Third_digit').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}
