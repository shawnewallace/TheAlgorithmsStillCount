module Fibonacci
  def self.phi()
    (1.0 + Math.sqrt(5)) / 2
  end
  
  def self.of(n)
    return ((Fibonacci.phi**n - (1.0 - Fibonacci.phi)**n) / Math.sqrt(5)).floor
  end
end