function subsum(arr, start, end){
    if (!Array.isArray(arr)) {
        return NaN;
    }

    if (arr.length === 0) {
        return 0;
    }

    if (!arr.every(Number)) {
        return NaN;
    }

    start = Math.max(0, start);
    end = Math.min(arr.length - 1, end);

    return arr.slice(start, end + 1).reduce((a, b) => a + b);
}

// console.log(subsum([10, 20, 30, 40, 50, 60], 3, 300));
// console.log(subsum([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1));
// console.log(subsum([10, 'twenty', 30, 40], 0, 2));
// console.log(subsum([], 1, 2));
// console.log(subsum('text', 0, 2));