var i, result, nlen, output,
    maxBits = Number.MAX_VALUE.toString(2).length,
    n = [5, 8, 0, 15, 5343, 62241],
    bitNumber = 3;
for (i = 0, nlen = n.length; i < nlen; i++) {
    result = n[i] << maxBits - (bitNumber+1);
    result = result >>> maxBits-1;
    output = 'n = ' + n[i] + '; bit #3 is: ' + result + '<br />';
    document.getElementById('Third_bit').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}
