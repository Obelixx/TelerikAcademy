var n, result, len, output,
	a = [5, -2, -2, 0, -3],
	b = [2, -22, 4, -2.5, -0.5],
    c = [2, 1, 3, 0, -1.1],
    d = [4, 0, 2, 5, -2],
    e = [1, 0, 0, 5, -0.1];
for (n = 0, len = Math.min(a.length, b.length,c.length,d.length,e.length) ; n < len ; n++) {
    if (a[n] >= b[n] && a[n] >= c[n] && a[n] >= d[n] && a[n] >= e[n]) {
        result = a[n];
    } else if (b[n] >= a[n] && b[n] >= c[n] && b[n] >= d[n] && b[n] >= e[n]) {
        result = b[n];
    } else if (c[n] >= a[n] && c[n] >= b[n] && c[n] >= d[n] && c[n] >= e[n]) {
        result = c[n];
    } else if (d[n] >= a[n] && d[n] >= b[n] && d[n] >= c[n] && d[n] >= e[n]) {
        result = d[n];
    } else if (e[n] >= a[n] && e[n] >= b[n] && e[n] >= c[n] && e[n] >= d[n]) {
        result = e[n];
    }
    output = 'a = ' + a[n] + '; b = ' + b[n] + ', c = ' + c[n] + '; d = ' + d[n] + '; e = ' + e[n] + '; result = ' + result + '<br />';
    if (document.getElementById('The_biggest_of_five_numbers') != null) document.getElementById('The_biggest_of_five_numbers').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}