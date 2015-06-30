/*
*
*Assuming Array exists in a different file.
*
*/

Array.ReturnSum = function(arr){
    var sum = 0;
    var i;
    for(i = 0; i<arr.length;i++){
        sum+=arr[i];
    }
    return sum;
}