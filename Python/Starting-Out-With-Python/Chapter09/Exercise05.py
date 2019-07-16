'''noonz
Random Number Frequencies
Write a program that generates 100 random numbers between 1 and 10. The program
should store the frequency of each number generated in a dictionary with the
number as the key, and the amount of times it has occured as the value. For
example, if the program generates the number 6 a total of 11 times, the
dictionary will contain a key of 6 with an associated value of 11. Once all of
the numbers have been generated, display information about the frequency of
each number.'''
import random

num_freq = {}

def get_numbers():
    for i in range(100):
        num = random.randint(1,10)
        if num in num_freq:
            num_freq[num] += 1
        else:
            num_freq[num] = 1

get_numbers()

for k,v in num_freq.items():
    print('-{} : {}'.format(k,v))

input()
