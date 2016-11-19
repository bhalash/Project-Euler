function range(start, end) {
    if (!end) {
        end = start;
        start = 1;
    }

    if (start > end) {
        [start, end] = [end, start];
    }

    return [...Array(end + 1).keys()].slice(start);
}

function sieve(arr) {
    if (!arr.length) {
        return [];
    } else {
        return [arr[0]].concat(sieve(arr.slice(1).filter(n => n % arr[0])));
    }
}

function factors(number) {
    const primes = sieve(range(2, number >> 1)).filter(n => !(number % n));
    return primes.length ? primes : [number];
}

factors(57);
factors(97);
factors(99997);
