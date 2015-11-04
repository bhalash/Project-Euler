require 'prime'

prime_factor = 600851475143.prime_division.map { |factor|
    factor[0] if Prime.prime?(factor[0])
}

p prime_factor.max
