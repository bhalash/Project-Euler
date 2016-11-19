#!/usr/bin/env node

const fs = require('fs');
const add = previous, current) => previous + current;

const toNumbers = string => {
    return string.split('').map((_, index) => string.charCodeAt(index) % 64);
}

fs.readFile('./p022_names.txt', 'utf8', (_, data) => {
    const names = JSON.parse(['[', data, ']'].join('')).sort();

    const reduced = names.map((name, index) => {
        return toNumbers(name).reduce(add) * (index + 1);
    }).reduce(add);

    console.log(reduced);
});
