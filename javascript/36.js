#!/usr/bin/env node

function range(start, end) {
    return [...Array(end + 1).keys()].slice(start);
}

function palindrome(number) {
    return number.toString() === number.toString().split('').reverse().join('');
}

function toBinary(number) {
    return (number >>> 0).toString(2);
}

function add(sum, current) {
    return sum + current;
}

const palindromes = range(1, 999999).filter(number => {
    return palindrome(number) && palindrome(toBinary(number));
});

console.log(palindromes.reduce(add));
