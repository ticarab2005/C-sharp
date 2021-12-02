// Matrix Search
// Given a 2-dimensional array and a smaller 2-dimensional array, return the location of the first match found, or [-1,-1] if no match is found
// Ex: given:
// [ [12,1,4,19],
//   [3,4,11,17],
//   [18,72,2,10],
//   [9,15,32,16]]
// and
// [ [11,17]
//   [2,10]]
// Return [1,2] (this is the location where the inner matrix begins)

// setup:
function matrixSearch(matrix, search) {
    let first = search[0][0];
    for(let i = 0; i < matrix.length - search.length + 1; i++){
        for(let j = 0; j < matrix[0].length - search[0].length + 1; j++){
            if(matrix[i][j] == first){
                let matching = true;
                    for(let k = 0; k < search.length; k++){
                        for(let l = 0; l < search[0].length; l++){
                            if(search[k][l] !== matrix[i + k][j + l]) {
                                matching = false;
                        }
                    }
                }
                if (matching) return [i,j];
            }
        }
    }
    return [-1,-1];
}
console.log(matrixSearch([ [12,1,4,19],[3,4,11,17],[18,72,2,10],[9,15,32,16]], [[11,17], [2,10]]));
console.log(matrixSearch([ [12,1,4,19],[3,4,11,17],[18,72,2,10],[9,15,32,16]], [[11,17], [2,11]]));

function matrixSearch(matrix, search){
    let position = [];
    for (let i = 0; i < matrix.length; i++){
        for (let j = 0; j < matrix[i].length; j++){
            if (matrix[j][i]==search[0][0]){
                if (matrix[j][i+1]==search[0][1]){
                    if(matrix[j+1][i]==search[1][0]){
                        if(matrix[j+1][i+1]==search[1][1]){
                            position = [j, i];
                            return position;
                        }
                    }
                }
            }
        }
    }
    return [-1,-1];
}
console.log(matrixSearch([ [12,1,4,19],[3,4,11,17],[18,72,2,10],[9,15,32,16]], [[11,17], [2,10]]));
console.log(matrixSearch([ [12,1,4,19],[3,4,11,17],[18,72,2,10],[9,15,32,16]], [[11,17], [2,11]]));