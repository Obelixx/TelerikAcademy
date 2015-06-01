var n, result, len, output,
	a = [5, -2, -2, 0, -1.1, 10, 1],
	b = [1, -2, 4, -2.5, -0.5, 20, 1],
    c = [2, 1, 3, 5, -0.1, 30, 1];
for (n = 0, len = Math.min(a.length, b.length, c.length) ; n < len ; n++) {
    // not using arrays for sorting!!
    if (a[n] > b[n]) {
        if (c[n] > a[n]) {
            result = [c[n], a[n], b[n]];
        } else if (c[n] > b[n]) {
            result = [a[n], c[n], b[n]];
        } else {
            result = [a[n], b[n], c[n]];
        }
    } else {
        if (c[n] > b[n]) {
            result = [c[n], b[n], a[n]];
        } else if (c[n] > a[n]) {
            result = [b[n], c[n], a[n]];
        } else {
            result = [b[n], a[n], c[n]]
        }
    }
    output = 'a = ' + a[n] + '; b = ' + b[n] + ', c = ' + c[n] + '; result = ' + result.join(', ') + '<br />';
    if (document.getElementById('Sort_3_numbers') != null) document.getElementById('Sort_3_numbers').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}