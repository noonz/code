'''noonz
Dice Rolling Function
In a program, write a function named roll that accepts an integer argument
numer_of_throws. The function should generate and return a sorted list of
number_of_throws random numbers between 1 and 6. The program should prompt the
user to enter a positive integer that is sent to the function, and then print
the returned list.'''
import random

def roll(num_of_throws):
    outcome = []
    
    for i in range(num_of_throws):
        outcome.append(random.randint(1,6))

    return outcome

def main():
    number_of_throws = int(input('How many throws: '))
    outcome = roll(number_of_throws)
    print('\nHere are your rolls:')

    '''for i in range(len(outcome)):
        if i == len(outcome)-1:
            print(outcome[i],end='')
        else:
            print(outcome[i],end=',')'''
    
    print(','.join(map(str,outcome)))
    print(','.join(str(i) for i in outcome))
    
    input()
        
main()
