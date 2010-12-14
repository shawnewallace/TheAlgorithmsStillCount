module Fibonacci
  def self.ofIterative(fib)
    return fib if fib == 0 or fib == 1
    sum = 0
    a = 0
    b = 1
    (2..fib).each do |n|
      sum = a + b
      a = b
      b = sum
    end
    sum
  end
  
  def self.ofRecursion(fib)
    return fib if fib == 0 or fib == 1
    
    return ofRecursion(fib - 1) +  ofRecursion(fib - 2)
  end
  
  def self.of(fib)
    (
      ((phi**fib) - (1.0 - phi)**fib) / Math.sqrt(5)
    ).floor
  end
  
  def self.phi
    (1.0 + Math.sqrt(5)) / 2
  end
end