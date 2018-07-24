#puts "Hello World"

puts "How old are you?"
age = gets.chomp
puts age + " is a fun age"
next_bd = age.to_i + 1
if next_bd % 10 == 0 && next_bd >=50
    puts "But #{next_bd}?!?! Now that calls for SHOTS!"
elsif next_bd % 10 == 0   
    puts "Wow, so next year is the big round #{next_bd}"
elsif next_bd == 18 || next_bd == 21
    case
    when next_bd == 18
            then puts "And next year you can vote"
    when next_bd == 21
            then puts "And next year I can buy you a drink"
    end
    #puts "And you have a major BD coming up next"
else 
    puts "And this time next year you'll be #{next_bd}"
end
