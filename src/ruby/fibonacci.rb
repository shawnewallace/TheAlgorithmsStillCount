module Fibonacci
  def self.ofIterative(fib)
    a = 0
    b = 1

    fib.times do |i|
      a, b = b, a + b
    end

    return a
  end
  
  def self.ofRecursion(fib)
    return fib if (0..1).include? fib
    
    return ofRecursion(fib - 1) +  ofRecursion(fib - 2)
  end
  
  def self.of(fib)
    (
      ((phi**fib) - (1.0 - phi)**fib) / Math.sqrt(5)
    ).floor
  end
  
  def self.phi
    @phi ||= (1.0 + Math.sqrt(5)) / 2
  end

	def self.cool(size)
		a,b = 0, 1   
    0.upto(size){
			puts a; a+=b; a,b= b,a
		} # note the swap for the next iteration		
	end
	
end
