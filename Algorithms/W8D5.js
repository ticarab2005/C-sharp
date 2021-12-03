// Taco Truck
// Joe drives a taco truck in the booming town of Squaresburg. He uses an array of [x,y] coordinates corresponding to locations of his customers. They walk to his truck, but he is fair-minded so he wants to minimize total distance from truck to customers. City blocks are perfect squares, and every street is two-way, at perfect right angles. He only parks by stree corners (coordinates like [37,-16]). Customers only travel on streets: coordinate [2,-2] is distance 4 from [0,0]. Joe checks the array before deciding where to park. Given a customer coordinate array, return an optimal taco truck location.
// Example: given [[10,0],[-1,-10],[2,4]] return [2,0], as total distance is 25 (8+13+4) which is the shortest possible combined distance for all customers.

function truck(customerArray) {
    for (var i = 0; i < customerArray.length; i++) {
        for (var j = 0; j < customerArray[i].length; j++) {
            var x = 0
        }
    }
}

function helper(customerArray, loc) {
    var sum = 0;
    for (var i = 0; i < customerArray.length; i++) {
        sum += Math.abs((customerArray[i][0] - loc[j]) + (customerArray[i][1] - loc[1]));
    }

}

const optimalDistance = (CoordinateArray) => {
    let location = [];
    let x = [];
    let y = [];
    for (let customer of CoordinateArray) {
        x.push(customer[0]);
        y.push(customer[1]);
    }

    x.sort((x, y) => x - y);
    y.sort((x, y) => x - y);

    location.push(x[Math.floor(x.length / 2)]);
    location.push(y[Math.floor(y.length / 2)]);

    return location;
};

console.log(
    optimalDistance([
        [10, 0],
        [-1, -10],
        [2, 4],
    ])
);