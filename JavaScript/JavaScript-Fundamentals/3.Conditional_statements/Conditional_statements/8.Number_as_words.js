var n, len, output, one, ten, hundred, number, words,
	numbers = [0, 9, 10, 12, 19, 25, 98, 98, 273, 400, 501, 617, 711, 999];
for (n = 0, len = numbers.length ; n < len ; n++) {
    number = numbers[n];
    one = number % 10;
    number /= 10;
    number |= 0;
    ten = number % 10;
    number /= 10;
    number |= 0;
    hundred = number % 10;
    words = '';
    if (hundred != 0) words = numberToWord(hundred) + " hundred";
    if (hundred != 0 && (ten > 0 || one > 0)) words += " and ";

    if (ten * 10 + one <= 13) {
        if (hundred != 0 && one != 0) words += numberToWord(ten * 10 + one);
        else
            if (hundred == 0) words += numberToWord(ten * 10 + one);
    }
    else {
        if (ten == 1) {
            if (one != 8) words += numberToWord(one) + "teen";
            else words += numberToWord(one) + "een";
        }
        else
            if (ten <= 5 && one == 0) words += numberToWord(ten * 10);
            else {
                if (ten <= 5 && one != 0) words += numberToWord(ten * 10) + " " + numberToWord(one);
                if (ten > 5 && one == 0) {
                    if (ten != 8) words += numberToWord(ten) + "ty";
                    else words += numberToWord(ten) + "y";
                }
                if (ten > 5 && one > 0) {
                    if (ten != 8) words += numberToWord(ten) + "ty " + numberToWord(one);
                    else words += numberToWord(ten) + "y " + numberToWord(one);
                }
            }
    }
    output = 'number = ' + numbers[n] + '; result = ' + words + '<br />';
    if (document.getElementById('Number_as_words') != null) document.getElementById('Number_as_words').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, "\n"));
}
//This function and the if statements from up was taken from my homework in C# course. Well, i made a little edits - but it works.
function numberToWord(digit) {
    switch (digit) {
        case 0:
            return ("zero");
        case 1:
            return ("one");
        case 2:
            return ("two");
        case 3:
            return ("three");
        case 4:
            return ("four");
        case 5:
            return ("five");
        case 6:
            return ("six");
        case 7:
            return ("seven");
        case 8:
            return ("eight");
        case 9:
            return ("nine");
        case 10:
            return ("ten");
        case 11:
            return ("eleven");
        case 12:
            return ("twelve");
        case 13:
            return ("thirteen");
        case 20:
            return ("twenty");
        case 30:
            return ("thirty");
        case 40:
            return ("fourty");
        case 50:
            return ("fifty");
        default:
            return ("not a digit");
    }
}
