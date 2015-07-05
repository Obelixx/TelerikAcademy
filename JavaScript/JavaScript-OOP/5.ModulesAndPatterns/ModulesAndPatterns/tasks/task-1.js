/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
    var Course = {
        init: function (title, presentations) {
            var _title,
                _presentations = [];

            Object.defineProperties(this, {
                title: {
                    get: function () {
                        return _title;
                    },
                    set: function (value) {
                        if (validateTitle(value)) {
                            _title = value;
                        } else {
                            throw new Error('Invalid title!');
                        }

                    }
                },
                presentations: {
                    get: function () {
                        return _presentations.slice();
                    },
                    set: function (value) {
                        if (validatePresentations(value)) {
                            _presentations = value;
                        } else {
                            throw new Error('Invalid presentations!');
                        }
                    }
                }
            })
            this.title = title;
            this.presentations = presentations;
            this.students = [];

            return this;
        },
        addStudent: function (name) {
            if (validateName(name)) {
                var firstAndLastName = name.split(' ');
                this.students.push(
                    {
                        firstname: firstAndLastName[0],
                        lastname: firstAndLastName[1],
                        id: this.students.length + 1
                    });
            } else {
                throw new Error('Invalid name!');
            }

            return this.students[this.students.length - 1].id;
        },
        getAllStudents: function () {
            return this.students.slice();
        },
        submitHomework: function (studentID, homeworkID) {
            if (!validateId(studentID, 1, this.students.length)) throw new Error('Invalid ID')
            if (!validateId(homeworkID, 1, this.presentations.length)) { throw new Error('Invalid ID') };
            return this;
        },
        pushExamResults: function (results) {
            var studentIdsInResults = [],
                i, len = results.length,
                uniqueStudentIdsInResults = []
            ;
            if (validateResultsArray(results)) {
                for (i = 0; i < len; i += 1) {
                    studentIdsInResults.push(results[i].StudentID)
                    if (results[i].StudentID > this.students.length || typeof (results[i].StudentID) !== 'number') {
                        throw new Error('Invalid ID (id > students)')
                    }

                }
                studentIdsInResults = studentIdsInResults.sort();
                studentIdsInResults.forEach(function (el, i) {
                    if (uniqueStudentIdsInResults.indexOf(el) === -1) uniqueStudentIdsInResults.push(el);
                });
                if (studentIdsInResults.length !== uniqueStudentIdsInResults.length) {
                    throw new Error('Dublicates in students IDs!')
                }

            } else {
                throw new Error('Invalid results Array!');
            }
        },
        getTopStudents: function () {
        }

    };

    function validateTitle(title) {
        if (title === undefined) { return false; };
        if (title.length === undefined) { return false; };
        if (title.length < 1) { return false; };
        if (title[0] === ' ' || title[title.length - 1] === ' ') { return false; };
        if (title.split('  ').length > 1) { return false; };

        //Not included in tests! And getting whrong result for:
        // - expect not to throw if titles are legit and contain all kinds of symbols

        //var titleChars = title.split('').filter(function (char) { return (char >= 'A' && char <= 'Z') || (char >= 'a' && char <= 'z') }).length;
        //if (titleChars <= 0) { return false; };

        return true;
    };

    function validatePresentations(presentations) {
        if (!(Array.isArray(presentations))) { return false; };
        if (presentations.length < 1) { return false; }
        for (var title in presentations) {
            if (!validateTitle(presentations[title])) {
                return false;
            }
        }
        return true
    };

    function validateName(name) {
        if (name === undefined) { return false; };
        if (name.length === undefined) { return false; };
        if (name.length < 1) { return false; };
        var firstAndLastName = name.split(' ');
        if (firstAndLastName.length !== 2) { return false; };
        if (firstAndLastName[0].charAt(0).toUpperCase() === firstAndLastName[0].charAt(0).toLowerCase()) { return false; }
        if (firstAndLastName[0].charAt(0) !== firstAndLastName[0].charAt(0).toUpperCase()) { return false; }
        if (firstAndLastName[0].length > 1) {
            if (firstAndLastName[0].substring(1) !== firstAndLastName[0].substring(1).toLowerCase()) { return false; }
        }
        if (firstAndLastName[1].charAt(0).toUpperCase() === firstAndLastName[1].charAt(0).toLowerCase()) { return false; }
        if (firstAndLastName[1].charAt(0) !== firstAndLastName[1].charAt(0).toUpperCase()) { return false; }
        if (firstAndLastName[1].length > 1) {
            if (firstAndLastName[1].substring(1) !== firstAndLastName[1].substring(1).toLowerCase()) { return false; }
        }

        return true;
    };

    function validateId(id, min, max) {
        if (id != Number(id)) { return false; }
        id = +id;
        if (id < min || id > max) { return false; }
        return true;
    };

    function validateResultsArray(results) {
        var i, len;
        if (results === undefined) { throw new Error(1); return false; };
        if (results.length === undefined) { throw new Error(2); return false; };
        if (results.length < 1) { throw new Error(3); return false; };

        len = results.length;
        for (i = 0; i < len; i++) {
            if (!results[i].StudentID || !results[i].score) { throw new Error(4); return false; };
            if (typeof (results[i].score) !== 'number') { throw new Error(5); return false; };
        };
        return true;
    };

    return Course;
}

module.exports = solve;

