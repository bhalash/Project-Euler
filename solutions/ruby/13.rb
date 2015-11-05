p File.read("13.txt").split(/\n/).map(&:to_i).reduce(:+).to_s[0,10].to_i
