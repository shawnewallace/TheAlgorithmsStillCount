require 'rubygems'
gem 'rspec'
require 'sum_of_even_fib'

describe Fibonacci do
  
  [
    [0, 0],
    [1, 1],
    [2, 1],
    [3, 2],
    [4, 3],
    [5, 5],
    [17, 1597],
    [45, 1134903170]
  ].each do |num, expected| 
    it "should be #{expected} if #{num}" do
      Fibonacci.of(num).should == expected
    end
  end
  
  
  it "should compute phi to be about 1.61" do
    Fibonacci.phi().should > 1.61
    Fibonacci.phi().should < 1.62
  end
  
end