class wild
    def can_u_c_me?
        puts 'I see you!'
    end
    def what_about_now?
        puts 'still here!'
    end
    def yep_ruby_is(adjective)
        puts "yes, ruby is #{adjective}"
    end
    def add_two_numbers(x,y)
        x + y
    end
end

w = Wild.new
puts w.add_two_numbers(2,5)
# w.can_u_c_me?
# w.send :what_about_now
# puts "Which method would you like to call?"
# method_name = gets.chomp
# w.send method_name.to_sym
# puts "How would you describe this language?"
# adj = gets.chomp
# w.send :yep_ruby_is, adj