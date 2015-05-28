var n, result, output;
for (n = 3; n >= -2; n -= 1) {
	result = (n % 2 !== 0);
	output = 'n = ' + n + '; Odd? - ' + result + '<br />';
	document.getElementById('Odd_or_Even').innerHTML += output;
	console.log(output.replace(/<br \/>/gi, "\n"));
}
