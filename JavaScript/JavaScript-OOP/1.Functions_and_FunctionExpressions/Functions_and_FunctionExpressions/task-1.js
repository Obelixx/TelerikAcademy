/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	
*/

function solve() {
    return function sum(arr) {
        if (arguments.length === 0) { throw new Error('the parameter is not passed'); }
        if (!arr.length) { return null; }
        var tempSum = 0, len, i;
        for (i = 0, len = arr.length; i < len; i += 1) {
            if (!(+arr[i])) { throw new Error('any of the elements is not convertible to Number'); }
            tempSum += +arr[i];
        }
        return (tempSum);
    }
    module.exports = sum;
}

arr = [1,2,'3']
sum = solve(arr);
console.log('arr = ' + arr.join(', '));
console.log('Prime numbers = ' + sum(arr));
