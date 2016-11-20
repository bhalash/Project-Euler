#!/usr/bin/env ruby

def fib(n)
    # fib(n) = round(ϕ ^n / √5)
    phi = 1.618033988749894
    sqrt_5 = 2.23606797749979
    (phi ** n / sqrt_5).round
end

fib_n = 0
fib_val = 0
fib_sum = 0

while true do
    fib_val = fib(fib_n)
    fib_n += 1

    break if fib_val > 4000000 
    next if fib_val % 2 != 0

    fib_sum += fib_val
end

puts fib_sum
