var output, result, last, count = 0, best_count = 0, i = 0, len = 0, end = 0;
sequence = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
//from my C# homework with edits for JavaScript..
while (sequence[i] != undefined) {
    if (sequence[i] == last) {
        count++;
        last = sequence[i];
    } else {
        count = 1;
        last = sequence[i];
    }
    if (best_count < count) {
        best_count = count;
        end = i;
    }
    i += 1;
}
result = sequence.filter(function (_, index) {
    return index > end - best_count && index <= end;
})
output = 'sequence = ' + sequence + '<br />' + 'result = ' + result.toString();
if (document.getElementById('Maximal_sequence') != null) document.getElementById('Maximal_sequence').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n'));