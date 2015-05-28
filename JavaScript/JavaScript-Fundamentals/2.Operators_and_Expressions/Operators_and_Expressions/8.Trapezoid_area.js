var n, result, len, output
a = [5, 2, 8.5, 100, 0.222],
b = [7, 1, 4.3, 200, 0.333],
h = [12, 33, 2.7, 300, 0.555];
for (n = 0, len = Math.min(a.length, b.length,h.length) ; n < len ; n++) {
    result = (a[n] +b[n])*h[n]/2
    output = 'a = ' + a[n] + '; b = ' + b[n] + '; h = ' + h[n] + '; area = ' + result + '<br />';
    document.getElementById('Trapezoid_area').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}