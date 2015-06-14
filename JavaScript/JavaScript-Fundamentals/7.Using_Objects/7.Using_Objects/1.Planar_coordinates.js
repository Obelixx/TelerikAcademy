var output = '', p1, p2, p3, p4, l1, l2, l3, l4;

p1 = makePoint('p1', 0, 0);
output += p1.toString() + '<br />';
p2 = makePoint('p2', 0, 1);
output += p2.toString() + '<br />';
p3 = makePoint('p3', 1, 0);
output += p3.toString() + '<br />';
p4 = makePoint('p4', 1, 1);
output += p4.toString() + '<br />';

l1 = makeLine('l1', p1, p2);
output += l1.toString() + '<br />';
l2 = makeLine('l2', p2, p3);
output += l2.toString() + '<br />';
l3 = makeLine('l3', p3, p1);
output += l3.toString() + '<br />';
l4 = makeLine('l4', p1, p4);
output += l4.toString() + '<br />';

output += '&nbsp; distance from p1 to p2 = ' + calculateDistance(p1, p2) + '<br />';
output += '&nbsp; distance from p2 to p3 = ' + calculateDistance(p2, p3) + '<br />';
output += '&nbsp; can l1,l2 and l3 form tiangle? - ' + canFormTriangele(l1, l2, l3) + '<br />';
output += '&nbsp; can l1,l2 and l4 form tiangle? - ' + canFormTriangele(l1, l2, l4) + '<br />';

if (document.getElementById('Planar_coordinates') != null) document.getElementById('Planar_coordinates').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function makePoint(name, x, y) {
    return {
        name: name,
        x: x,
        y: y,
        toString: function () {
            return this.name + '(' + this.x + ';' + this.y + ')';
        }
    }
}

function makeLine(name, p1, p2) {
    if (p1.x === p2.x && p1.y === p2.y) {
        return "Cant form line with two identical points!";
    }
    return {
        name: name,
        p1: p1,
        p2: p2,
        toString: function () {
            return this.name + '(' + this.p1.toString() + ';' + this.p2.toString() + ')';
        }
    }
}

function calculateDistance(p1, p2) {
    return Math.sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
}

function canFormTriangele(l1, l2, l3) {
    var i, length, arr = [l1.p1, l1.p2, l2.p1, l2.p2, l3.p1, l3.p2],
        arrD = [calculateDistance(l1.p1, l1.p2), calculateDistance(l2.p1, l2.p2), calculateDistance(l3.p1, l3.p2)];
    if (arrD[0] + arrD[1] <= arrD[2]) { return false; }
    if (arrD[1] + arrD[2] <= arrD[0]) { return false; }
    if (arrD[2] + arrD[0] <= arrD[1]) { return false; }
    if (arr[0].x === arr[4].x && arr[0].y == arr[4].y) {
        arr.splice(4, 1);
        arr.splice(0, 1);
    } else if (arr[0].x == arr[5].x && arr[0].y == arr[5].y) {
        arr.splice(5, 1);
        arr.splice(0, 1);
    } else return false;

    if (arr[0].x === arr[1].x && arr[0].y == arr[1].y) {
        arr.splice(1, 1);
        arr.splice(0, 1);
    } else if (arr[0].x == arr[2].x && arr[0].y == arr[2].y) {
        arr.splice(2, 1);
        arr.splice(0, 1);
    } else return false;

    if (arr[0].x === arr[1].x && arr[0].y == arr[1].y) {
        arr.splice(1, 1);
        arr.splice(0, 1);
    } else return false;

    return true;
}