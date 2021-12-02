// Remove duplicates
// Given a sorted array of integers, remove all duplicates from the array and return an array that does not contain duplicates (okay to make a new array)
function SortArry(Arr){
    newArr = [];
    for(var i = 0; i < Arr.length; i++){
        if(Arr[i] != newArr[newArr.length-1]){
            newArr.push(Arr[i]);            
        }
    }
    return newArr;
}
console.log(SortArry([1,1,1,2,3,3,4]));

function unSortArry(Arr){
    newArr = [];
    for(var i = 0; i < Arr.length; i++){
        if(Arr[i] != newArr[newArr.length-1]){
            newArr.push(Arr[i]);            
        }
    }
    return newArr;
}
console.log(unSortArry([2,2,3,4,4,4]));

function removeDuplicates(arr){
    for(i=0;i<arr.length;i++){
        let num = arr[i];
        for(j=i+i;j<arr.length;j++){
            if(arr[j]==num){
                arr.splice(j,1);
                j--;
            }
        }
    }
    return arr;
}
console.log(removeDuplicates([1,1,4,8,6,8,2,3,6,0,1,4]));

// Splice
var arr = [1,2,3,4,5];

function mySplice(arr,idx, valsToRem){
    for(var i=idx;i<arr.length;i++){
        arr[i] = arr[i+valsToRem];
    }
    for(var j=0;j<valsToRem;j++){

        arr.pop();
    }
    return arr;
}
console.log(mySplice(arr,1,2));


// var arr = [1,2,3,4,5];

// function mySplice(arr, idx, valsToRem){
//     for(var i = idx; i < arr.length; i++){
//         arr[i] = arr[i+valsToRem];
//     }
//     arr.length = arr.length - valsToRem;
//     return arr;
// }

// console.log(mySplice(arr, 1, 2));
// Ex: given [1,1,1,2,3,3,4] > return [1,2,3,4]
// Ex: given [2,2,3,4,4,4] > return [2,3,4]

// Challenge one: How would you do this with an unsorted array?


// Challenge two: try to do this WITHOUT making a new array! (Also known as in place)
