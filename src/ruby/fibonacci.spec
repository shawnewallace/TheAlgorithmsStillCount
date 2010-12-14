require 'rubygems'
gem 'rspec'
require 'fibonacci'

describe Fibonacci do
=begin
  it "should be 0 if 0" do
    Fibonacci.of(0).should == 0
  end
  
  it 'should be 1 if 1' do
    Fibonacci.of(1).should == 1
  end
  
  it 'should be 1 if 2' do
    Fibonacci.of(2).should == 1
  end
=end
  
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
    end
  end
  
  it "PHI should be about 1.61" do
      Fibonacci.phi().should > 1.61
      Fibonacci.phi().should < 1.62
  end
end