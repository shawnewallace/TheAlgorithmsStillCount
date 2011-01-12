module Fibonacci
  def self.ofIterative(fib)
    old = 0
    new = 1

    fib.times do |i|
      old, new = new, old + new
    end

    return old
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
	
end
