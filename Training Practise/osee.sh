#! /bin/bash
N=8
  
# First Number of the
# Fibonacci Series
a=0
  
# Second Number of the
# Fibonacci Series
b=1 
   
echo "The Fibonacci series is : "
   
for (( i=0; N>1; i++ ))
do
    echo -n "$a "
    fn=$((a + b))
    a=$b
    b=$fn
done