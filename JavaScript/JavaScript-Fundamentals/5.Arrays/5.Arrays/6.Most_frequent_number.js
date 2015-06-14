var output, result, last, i, j, len, most_frequent, most_frequent_count = 0, temp_count = 1, end = 0,
sequence = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
//from my C# homework with edits for JavaScript..
most_frequent = sequence[0];
arr_size = sequence.length;
for (i = 0; i < arr_size - 1; i += 1) {
    temp_count = 1;
    for (j = i + 1; j < arr_size; j += 1) {
        if (sequence[i] == sequence[j]) temp_count += 1;
    }
    if (most_frequent_count < temp_count) {
        most_frequent_count = temp_count;
        most_frequent = sequence[i];
    }
}
result = most_frequent + ' (' + most_frequent_count + ' times)';
output = 'sequence = ' + sequence + '<br />' + 'result = ' + result.toString();
if (document.getElementById('Most_frequent_number') != null) document.getElementById('Most_frequent_number').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n'));