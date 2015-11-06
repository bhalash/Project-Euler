#!/usr/bin/env ruby
require 'time'

sundays = 0

(1901..2000).each { |year|
    (1..12).each { |month|
        if Time.parse("#{year}-#{month}-1").strftime("%u").to_i % 7 == 0
            sundays += 1
        end
    }
}

p sundays
