var output, result, last, count = 0, best_count = 0, i = 0, len = 0, end = 0,
sequence = [3, 2, 3, 4, 2, 2, 4, 1];

output = 'sequence = ' + sequence + '<br />';
if (document.getElementById('Selection_sort') != null) document.getElementById('Selection_sort').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n'));

SelectionSort(sequence);
result = sequence.toString();
output = 'result = ' + result.toString();
if (document.getElementById('Selection_sort') != null) document.getElementById('Selection_sort').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n'));

//from my C# homework with edits for JavaScript..
function SelectionSort(not_sorted_array_of_ints) // sorts the given array
{
    var smallest, position, len, len1, i;
    for (position = 0, len = not_sorted_array_of_ints.length; position < len - 1; position += 1) {
        //Find the smallest element, 
        smallest = position;//assume smallest is first element
        for (i = position + 1, len1 = not_sorted_array_of_ints.length; i < len1; i += 1)//check rest of them
        {
            if (not_sorted_array_of_ints[smallest] > not_sorted_array_of_ints[i]) smallest = i;
        }
        if (smallest != position) //if there is smallest in the rest - exchange
        {
            not_sorted_array_of_ints[smallest] = not_sorted_array_of_ints[smallest] + not_sorted_array_of_ints[position];
            not_sorted_array_of_ints[position] = not_sorted_array_of_ints[smallest] - not_sorted_array_of_ints[position];
            not_sorted_array_of_ints[smallest] = not_sorted_array_of_ints[smallest] - not_sorted_array_of_ints[position];
        }
    }
}