/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/


function solve() {
    var Person = (function () {
        function Person(firstname, lastname, age) {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.fullname = firstname + ' ' + lastname;
        }

        Object.defineProperties(Person.prototype, {
            firstname: {
                set: function (value) {
                    if (checkName(value)) {
                        this._firstname = value;
                    }
                    return this;
                },
                get: function () {
                    return this._firstname;
                }
            },
            lastname: {
                set: function (value) {
                    if (checkName(value)) {
                        this._lastname = value;
                    }
                    return this;
                },
                get: function () {
                    return this._lastname;
                }
            },
            age: {
                set: function (value) {
                    if (checkAge(value)) {
                        this._age = value;
                    }
                },
                get: function () {
                    return this._age;
                }
            },
            fullname: {
                set: function (value) {
                    this.firstname = value.split(' ')[0];
                    this.lastname = value.split(' ')[1];
                    this._fullname = this.firstname + ' ' + this.lastname;
                },
                get: function () {
                    return this._fullname;
                }
            },
            introduce: {
                value: function () {
                    return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
                }
            }
        });

        function checkName(name) {
            if (name.length >= 3 && name.length <= 20) {
                if (checkIsLatinCharsOnly(name)) {
                    return true;
                }
            }
            throw new Error('Invalid name!');
        }

        function checkIsLatinCharsOnly(str) {
            var i, length;
            for (i = 0, length = str.length; i < length; i++) {
                if (str[i] < 'A' || str[i] > 'z') {
                    return false;
                }
            }
            return true;
        }

        function checkAge(number) {
            if (number >= 0 && number <= 150) {
                return true;
            } else {
                throw new Error('Invalid age!');
            }
        }

        return Person;
    }());
    return Person;
}
module.exports = solve;
