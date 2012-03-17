require 'fibonacci'

describe Fibonacci do
  @values = [
    [0, 0],
    [1, 1],
    [2, 1],
    [3, 2],
    [4, 3],
    [5, 5],
    [17, 1597],
    [45, 1134903170],
    [83, 99194853094755497]
  ]

  @values.each do |fib, expected|
    it "is #{expected} for fib(#{fib}) computed iteratively" do
      Fibonacci.ofIterative(fib).should == expected
    end
  end

  # @values.each do |fib, expected|
  #   it "is #{expected} for fib(#{fib}) computed recursively" do
  #     Fibonacci.ofRecursion(fib).should == expected
  #   end
  # end

  @values.each do |fib, expected|
    it "is #{expected} for fib(#{fib}) computed using O(1) calculation" do
      Fibonacci.of(fib).should == expected
    end
  end
end
