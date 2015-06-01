var n, len, output, x1, x2,
	a = [2, -1, -0.5, 5],
	b = [5, 3, 4, 2],
    c = [-3, 0, -8, 8];
for (n = 0, len = Math.min(a.length, b.length, c.length) ; n < len ; n++) {
    x1 = -b[n] / 2 / a[n] + Math.pow(b[n] * b[n] - 4 * a[n] * c[n], 0.5) / 2 / a[n];
    x2 = -b[n] / 2 / a[n] - Math.pow(b[n] * b[n] - 4 * a[n] * c[n], 0.5) / 2 / a[n];
    if (isNaN(x1) || isNaN(x2)) { x1 = x2 = 'No real roots!'; }
    output = 'a = ' + a[n] + '; b = ' + b[n] + ', c = ' + c[n] + '; roots:<br />x1 = ' + x1 + '<br />x2 = ' + x2 + ' <br />';
    if (document.getElementById('Quadratic_equation') != null) document.getElementById('Quadratic_equation').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}