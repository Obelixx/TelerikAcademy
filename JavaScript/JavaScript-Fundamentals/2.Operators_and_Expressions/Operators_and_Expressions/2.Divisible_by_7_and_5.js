var result,n,output,
    ints = [3,0,5,7,35,140,150];
for (n of ints) {
    result = (n % (5*7) === 0);
    output = 'n = ' + n + '; Divided by 7 and 5? - ' + result + '<br />';
    document.getElementById('Divisible_by_7_and_5').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}