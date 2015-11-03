#!/usr/bin/env ruby

def sum_to(multiple, end_num)
    end_num = end_num.to_f
    multiple = multiple.to_f

    end_num = end_num - (end_num % multiple)

    return ((end_num / multiple / 2) * (end_num + multiple)).to_i
end

puts(sum_to(3, 999) + sum_to(5, 999) - sum_to(15, 999))
