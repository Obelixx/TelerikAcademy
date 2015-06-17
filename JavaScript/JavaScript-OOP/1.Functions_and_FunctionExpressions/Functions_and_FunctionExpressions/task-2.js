//Task 2.

//Write a function that finds all the prime numbers in a range
//    It should return the prime numbers in an array
//    It must throw an Error if any of the range params is not convertible to Number
//    It must throw an Error if any of the range params is missing

function solve() {
    return function PrimesInRange(start, end) {
        var i, arrOfPrimes = [];
        if (start === undefined || end === undefined) { throw new Error('any of the range params is missing') }
        if (!(+start || +end)) { throw new Error('any of the range params is not convertible to Number') }
        start = +start;
        end = +end;
        if (start > end) {
            start = start + end;
            end = start - end;
            start = start + end
        }
        for (i = start; i <= end; i += 1) {
            if (isPrime(i)) {
                arrOfPrimes.push(i);
            }
        }
        return arrOfPrimes;

        function isPrime(num) {
            var i;
            for (i = 2; i < num; i++) {
                if (!(num % i)) break;
            }
            return (i === num);
        }
    }
    module.exports = PrimesInRange;
}


var start = 0;
var end = 5;
PrimesInRange = solve(start, end);
console.log('start = ' + start + ' end = ' + end);
console.log('Prime numbers = ' + PrimesInRange(start, end));