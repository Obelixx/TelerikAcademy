var n, result, len, output,
	width = [3, 2.5, 5, 9],
	height = [4, 3, 5, 9];
for (n = 0, len = Math.min(width.length, height.length) ; n < len ; n++) {
	result = width[n] * height[n];
	output = 'width = ' + width[n] + '; height = ' + height[n] + '; area = ' + result + '<br />';
	document.getElementById('Rectangle_area').innerHTML += output;
	console.log(output.replace(/<br \/>/gi, "\n"));
}