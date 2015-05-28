var n, result, len, output
x = [0, -5, -4, 1.5, -4, 100, 0, 0.2, 0.9, 2],
y = [1, 0, 5, -3, -3.5, -30, 0, -0.8, -4.93, 2.655],
radius = 5;
for (n = 0, len = Math.min(x.length, y.length) ; n < len ; n++) {
    result = (x[n] * x[n] + y[n] * y[n] <= radius * radius);
    output = 'x = ' + x[n] + '; y = ' + y[n] + '; inside? = ' + result + '<br />';
    document.getElementById('Point_in_Circle').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}