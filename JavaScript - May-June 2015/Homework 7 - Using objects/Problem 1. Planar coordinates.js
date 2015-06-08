/*  Write functions for working with shapes in standard Planar coordinate system.
	Points are represented by coordinates P(X, Y)
	Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
	Calculate the distance between two points.
	Check if three segment lines can form a triangle.
 */

(function () {
    'use strict';

	function point(x, y) {
		return {
			x: x,
			y: y
		};
	}

	function line(p1, p2) {
		return {
			p1: p1,
			p2: p2
		};
	}
    
    //calculate distance between 2 poaints
    function calculatePointsDistance (p1, p2) {
        return Math.sqrt(Math.pow(Math.abs(p1.x - p2.x), 2) + Math.pow(Math.abs(p1.y - p2.y), 2));
    }
    
    
    // http://stackoverflow.com/questions/19835174/how-to-check-if-3-sides-form-a-triangle-in-c
    function checkIfTriangle (l1, l2, l3) {
            var line1 = calculatePointsDistance(l1.p1, l1.p2),
                line2 = calculatePointsDistance(l2.p1, l2.p2),
                line3 = calculatePointsDistance(l3.p1, l3.p2);

        if ((line1 + line2 > line3) && (line1 + line3 > line2) && (line2 + line3 > line1)) {
            return true;
        }
        return false;
    }
    
	var p1 = point(5, 10);
	var p2 = point (-5, -5);
    
    var result = calculatePointsDistance(p1, p2);
    console.log('Points distance = ' + result);
    
    var l1 = line ({x: 0, y: 0}, {x:0, y: 3});
    var l2 = line ({x: 0, y: 0}, {x:0, y: 4});
    var l3 = line ({x: 0, y: 0}, {x:0, y: 5});
    
    var result = checkIfTriangle (l1, l2, l3);
    console.log('Can form a trialgle: ' + result);
	
})();