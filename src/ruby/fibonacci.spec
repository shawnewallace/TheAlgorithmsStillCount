require 'rubygems'
gem 'rspec'
require 'fibonacci'

describe Fibonacci do
  [
    [0, 0],
    [1, 1],
    [2, 1],
    [3, 2],
    [4, 3],
    [5, 5],
    [17, 1597],
    [45, 1134903170],
    [83, 99194853094755497]
    ].each do |fib, expected|
    it "should be #{expected} if #{fib}" do
      #Fibonacci.ofIterative(fib).should == expected
      #Fibonacci.ofRecursion(fib).should == expected
      Fibonacci.of(fib).should == expected
      #Fibonacci.cool(fib).should == expected
    end
  end
end