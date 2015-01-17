#!/bin/bash

A=13.txt

for i in {1..100}
do 
	B=`expr $B + $(sed -n "${i}{p}" $A)`
done

echo
echo -n $B | cut -c 1-10
echo
