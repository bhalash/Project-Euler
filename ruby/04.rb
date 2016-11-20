#!/usr/bin/env ruby

def palindrome?(str)
    str == str.reverse
end

def largest_palindrome(range)
    palindromes = []

    range.each { |x|
        range.each { |y|
            xy = x * y
            palindromes << xy if palindrome?(xy.to_s)
        }
    }

    palindromes.max
end

p largest_palindrome 100..999
