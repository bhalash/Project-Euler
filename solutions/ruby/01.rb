#!/usr/bin/env ruby

def sum_to(multiples, end_num)
    end_num.to_f

    multiples.map! { |number|
        number = number.to_f
        max = end_num - (end_num % number)
        number = ((max / number / 2) * (max + number))
    }

    return multiples
end

three, five, fifteen = sum_to([3, 5, 15], 999)
puts((three + five - fifteen).to_i)
