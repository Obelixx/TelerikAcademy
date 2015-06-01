var len, output, result = [],
	n = 22;
for (i = 1, len = n ; i <= len ; i++) {
    if (!(i % 3 === 0 && i % 7 === 0)) { result.push(i); }
}
output = 'n = ' + n + '<br />' + result.join(', ');
if (document.getElementById('Numbers_not_divisible') != null) document.getElementById('Numbers_not_divisible').innerHTML += output;
console.log(output.replace(/<br \/>/gi, "\n"));