// / Binary Search
// Given a sorted array and a value, return whether the array contains that value.
// Do not sequentially iterate through the array. Instead, ‘divide and conquer’, taking advantage of the fact that the array is sorted.

// Ex: Given [1,3,4,6,8,10] and 3, return true
// Ex: Given [2,6,8,10,14,16] and 12, return false

// function binarySearch (arr, val){
//     var start = 0; 
//     var end = arr.length - 1;
//     while (start <= end) {
//         var mid = Math.floor((start + end) / 2);
    
//         if (arr[mid] === val) {
//         return mid;
//         }
//     }
// }


function recursiveBinarySearch(arr,val,low = 0, high = arr.length){
    if(low > high){
        return false;
    }
    mid = Math.floor((low+high)/2);
    if(val === arr[mid]){
        return true;
    }
    else if(val < arr[mid]){
        return recursiveBinarySearch(arr,val,low,mid-1);
    }
    else{
        return recursiveBinarySearch(arr,val,mid+1,high);
    }
}

console.log(recursiveBinarySearch([1,3,4,6,8,10],3));
console.log(recursiveBinarySearch([2,6,8,10,14,16],12));

function iterativeBinarySearch(arr, val) {
    var start = 0;
    var end = arr.length - 1;

    while (start <= end){
        var middle = Math.floor((start + end) / 2);
        if (arr[middle] === val){
            return true;
        } else if (arr[middle] < val){
            start = middle + 1;
        }else {
            end = middle - 1;
        }
    }
    return false;
}
console.log(iterativeBinarySearch([1,2,3,5,7,9,10,11,13,14,15,56,78],5));