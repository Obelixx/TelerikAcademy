var n, result, len, output,
	a = [5, -2, -2, 0, -0.1, -0],
	b = [2, -2, 4, -2.5, -0.5, -5],
    c = [2, 1, 3, 5, -1.1, 1];
for (n = 0, len = Math.min(a.length, b.length) ; n < len ; n++) {
    if (a[n] > b[n]) {
        result = a[n];
        if (c[n] > a[n]) {
            result = c[n];
        }
    } else {
        result = b[n];
        if (c[n] > b[n]) {
            result = c[n];
        }
    }
    output = 'a = ' + a[n] + '; b = ' + b[n] + ', c = ' + c[n] + '; result = ' + result + '<br />';
    if (document.getElementById('The_biggest_of_Three') != null) document.getElementById('The_biggest_of_Three').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}