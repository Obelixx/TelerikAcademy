var len, output, min, max,
	sequence = [1, 3, 4, 5, 8, 123, 44, 2, 3, -3, 6, 2];
if (sequence[0] !== undefined) min = max = sequence[0];
for (i = 0, len = sequence.length ; i <= len ; i++) {
    if (sequence[i] > max) max = sequence[i];
    if (sequence[i] < min) min = sequence[i];
}
output = 'sequesnce = ' + sequence.join(', ') + '<br />' + 'min = ' + min + '<br />' + 'max = ' + max;
if (document.getElementById('MinMax_of_sequence') != null) document.getElementById('MinMax_of_sequence').innerHTML += output;
console.log(output.replace(/<br \/>/gi, "\n"));