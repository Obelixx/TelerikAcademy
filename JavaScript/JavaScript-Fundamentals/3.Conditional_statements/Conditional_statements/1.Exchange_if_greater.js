var n, len, output, input,
	a = [5, 2, 5.5,100],
	b = [2, 4, 4.5,-100];
input = 'input:' + '<br />' + 'a = ' + a.join(', ') + '<br />' + 'b = ' + b.join(', ') + '<br /><br /> output: <br />';
if (document.getElementById('Exchange_if_greater') != null) document.getElementById('Exchange_if_greater').innerHTML += input;
console.log(input.replace(/<br \/>/gi, "\n"));
for (n = 0, len = Math.min(a.length, b.length) ; n < len ; n++) {
    if (a[n] > b[n]) {
        a[n] = a[n] + b[n];
        b[n] = a[n] - b[n];
        a[n] = a[n] - b[n];
    }
    output = 'a = ' + a[n] + '; b = ' + b[n] + '<br />';
    if (document.getElementById('Exchange_if_greater') != null) document.getElementById('Exchange_if_greater').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}