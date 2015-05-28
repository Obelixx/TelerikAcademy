var n, result, len, output, insideCircle, outsideRectangle,
x = [1, 3, 0, 4, 2, 4, 2.5, 3.5, -100, 2],
y = [4, 2, 1, 1, 0, 0, 1.5, 1.5, -100, 2],
kx = 1, ky = 1, radius = 3,
rtop = 1, rleft = -1, width = 6, height = 2;
// to be in rectangle:
// x is form [rleft to rleft+width]
// y is from [rtop-height to rtop]

for (n = 0, len = Math.min(x.length, y.length) ; n < len ; n++) {
    insideCircle = ((x[n] - kx) * (x[n] - kx) + (y[n] - ky) * (y[n] - ky)) <= radius * radius;
    outsideRectangle = !((x[n] >= rleft) && (x[n] <= rleft + width) && (y[n] >= rtop - height) && (y[n] <= rtop));
    result = insideCircle && outsideRectangle;
    output = 'x = ' + x[n] + '; y = ' + y[n] + '; inside K & outside of R? = ' + result + '<br />';
    document.getElementById('Point_in_Circle_and_outside_Rectangle').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}