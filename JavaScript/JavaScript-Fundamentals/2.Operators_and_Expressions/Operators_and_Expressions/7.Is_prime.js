var i, result, nlen, output,
    n = [1, 2, 3, 4, 9, 37, 97, 51, -3, 0];
for (i = 0, nlen = n.length; i < nlen; i++) {
    result = isPrime3(n[i]);
    output = 'n = ' + n[i] + '; Is prime? - ' + result + '<br />';
    document.getElementById('Is prime').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}


//taken from: http://www.javascripter.net/faq/numberisprime.htm
function isPrime3(n) {
    if (isNaN(n) || !isFinite(n) || n % 1 || n < 2) return false;
    if (n % 2 == 0) return (n == 2);
    if (n % 3 == 0) return (n == 3);
    var m = Math.sqrt(n);
    for (var i = 5; i <= m; i += 6) {
        if (n % i == 0) return false;
        if (n % (i + 2) == 0) return false;
    }
    return true;
}