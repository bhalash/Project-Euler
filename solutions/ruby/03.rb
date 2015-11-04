#!/usr/bin/env ruby

require 'prime'

p 600851475143.prime_division.map { |factor|
    factor[0] if Prime.prime?(factor[0])
}.max
