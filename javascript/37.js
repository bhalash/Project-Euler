function range(start, end) {
    return [...Array(end + 1).keys()].slice(start);
}

function prime(number) {
    for (let i = 2; i < Math.sqrt(number); i++) {
        if (number % i === 0) {
            return false;
        }
    }

    return true;
}

function shift(number) {
    let circulars = [number];

    for (let i = 0; i < number.toString().length - 1; i++) {
        circulars.push(parseInt([circulars[i] % 10, Math.floor(circulars[i] / 10)].join('')));
    }

    return circulars;
}

function circularPrime(number) {
    return shift(number).every(prime);
}

console.log(range(2, 999999).filter(circularPrime).length);
