puts "How old are you?"
age = gets.chomp
puts age + " is a fun age"
next_bd = age.to_i + 1

puts "And this time next year you'll be #{next_bd}"
puts "wow, so next year is the big round #{next_bd}" if next_bd % 10 == 0 
puts "But #{next_bd}?!?! Now that calls for SHOTS!" if next_bd % 10 == 0 && next_bd >=50
puts "And next year you can vote" if next_bd == 18




puts "Sir, the possibilyt of successfully navigating an asteroid field is 3720 to 1" unless audience.member

puts archer==true? "Phrasing!" : "How DO you get ants"