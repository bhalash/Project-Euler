/**
 * Find the last element in an array where predicate returns true.
 *
 * @param {array} array - Array to test.
 * @param {function} predicate - Callback function to execute.
 * @param {number=} [index=array.length - 1] - Starting index.
 * @return {number} First index matching predicate, -1 if not matched.
 */

function findLastIndex(array, predicate, index) {
    if (!Number.isInteger(index)) {
        index = array.length - 1;
    }

    if (index < 0 || predicate(array[index], index, array)) {
        return index;
    } else {
        return findLastIndex(array, predicate, index - 1);
    }
}

/**
 * Generator which performs lexicographic permutations on an array, more-or-less
 * endlessly.
 *
 * @see https://projecteuler.net/problem=24
 * @see https://en.wikipedia.org/wiki/Permutation#Generation_in_lexicographic_order
 * @see https://www.nayuki.io/res/next-lexicographical-permutation-algorithm/next-permutation-algorithm.png
 * @require findLastIndex
 * @param {array} array - Array to permute. Strings should be split and joined outside.
 * @return {object} - Iterator object.
 */

function* lexicographer(array) {
    let pivot, largest, successor;

    while (true) {
        // Yield first to ensure the proper first iteration (the unchanged collection) is output.
        yield array;

        pivot = findLastIndex(array, (number, index) => number < array[index + 1]);
        // Largest such element in an array.
        largest = pivot + 1;
        // Last element such that it is bigger than the pivot, and smaller or equal to the largest.
        successor = findLastIndex(array, (number, index) => array[pivot] < number && number <= array[largest]);
        // Swap the pivot and successor.
        [array[pivot], array[successor]] = [array[successor], array[pivot]];
        // Return the rest of the array with the end reversed.
        array = array.slice(0, largest).concat(array.slice(largest).reverse());
    }
}

const permuter = lexicographer([...Array(10).keys()]);
let permutation;

for (var i = 0; i < 1000000; i++) {
    permutation = permuter.next().value;
}

console.log(permutation.join(''));
