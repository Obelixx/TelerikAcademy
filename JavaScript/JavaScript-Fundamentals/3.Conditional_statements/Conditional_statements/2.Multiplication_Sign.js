var n, result, len, output, input,
	a = [5, -2, -2, 0, -1, -0],
	b = [2, -2, 4, -2.5, -0.5, -5],
    c = [2, 1, 3, 4, -5.1, 1];
input = 'input:' + '<br />a = ' + a.join(', ') + '<br />b = ' + b.join(', ') + '<br />c = ' + c.join(', ') + '<br />' + '<br /> output: <br />';
if (document.getElementById('Multiplication_Sign') != null) document.getElementById('Multiplication_Sign').innerHTML += input;
console.log(input.replace(/<br \/>/gi, "\n"));
for (n = 0, len = Math.min(a.length, b.length) ; n < len ; n++) {
    if (a[n] === 0 || b[n] === 0 || c[n] === 0) result = 0;
    else {
        if (a[n] < 0) {
            result = false;
        } else { result = true; }
        if (b[n] < 0) { result = !result; }
        if (c[n] < 0) { result = !result; }
        if (result) {
            result = "+";
        } else { result = '-'; }
    }

    output = 'a = ' + a[n] + '; b = ' + b[n] + ', c = ' + c[n] + '; result = ' + result + '<br />';
    if (document.getElementById('Multiplication_Sign') != null) document.getElementById('Multiplication_Sign').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}