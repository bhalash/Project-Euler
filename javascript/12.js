function divisorCount(number) {
    let end = Math.ceil(Math.sqrt(number));
    let divisorCount = 0;

    for (let i = 1; i < = end; i++) {
        if (!(number % i)) {
            divisorCount += 2;
        }
    }

    return divisorCount;
}

function* triangleGenerator(number) {
    let current = 0;

    while (true) {
        current += 1;
        yield (current + 1) * current >> 1;
    }
}

function solver(goal, generator) {
    const triangle = generator.next().value;

    if (divisorCount(triangle) > goal) {
        return triangle;
    } else {
        return solver(goal, generator);
    }
}

console.log(solver(500, triangleGenerator()));