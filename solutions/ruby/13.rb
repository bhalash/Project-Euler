p File.read("13.txt").split(/\n/).map(&:to_i).reduce(:+).to_s[0..9].to_i
