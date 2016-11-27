function probableMax(power) {
    return Math.pow(9, power + 1);
}

function powerDigits(number, power) {
    return (number).toString().split('').map(digit => {
        return Math.pow(parseInt(digit), power);
    }).reduce((sum, current) => {
        return sum + current;
    });
}

const power = 5;
let sum = 0;

for (let i = 2; i < probableMax(power); i++) {
    if (powerDigits(i, power) === i) {
        sum += i;
    }
}

console.log(sum);
