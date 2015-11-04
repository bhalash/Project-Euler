def factorial(n)
    n > 1 ? n * factorial(n - 1) : 1
end

p factorial(100).to_s.split(//).map(&:to_i).inject { |sum, x|
    sum + x
}
