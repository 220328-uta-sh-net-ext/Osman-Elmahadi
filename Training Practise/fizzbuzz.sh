#! /usr/bin/bash
echo -n "Please input number => "
read num

for i in $(seq 1 ${num})
do
  if (( $i % 3 == 0 && $i % 5 == 0 ))
  then
    echo "FizzBuzz"
  else if (( $i % 3 == 0))
    then
      echo "Fizz"
    else if (( $i % 5 == 0 ))
      then
        echo "Buzz"
      else
      echo $i
      fi
    fi
  fi
  sleep 1
done