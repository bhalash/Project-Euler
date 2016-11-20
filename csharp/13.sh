#!/bin/bash

sum=0

for line in $(cat '13.txt'); do
    sum=$(bc <<< "${sum} + ${line}")
done

cut -c 1-10 <<< $sum
