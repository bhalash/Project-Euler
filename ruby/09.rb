def fib_triple_side(n)
    n + 1 >> 1
end

def fib_triple(n)
    if n % 2 == 0
        warn("Warning: Number #{n} will not generate a Fibonacci triplet.")
        [0,0,0]
    elsif n == 1
        [1,0,1]
    else
        sides = []

        n_squared = n ** 2

        sides << n
        sides << fib_triple_side(n_squared - 2)
        sides << fib_triple_side(n_squared)
    end
end
