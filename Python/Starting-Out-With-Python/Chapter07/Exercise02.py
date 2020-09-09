'''noonz
Lottery Number Generator
Design a program that generates a seven-digit lottery number. The program should
generate seven random numbers, each in the range of 0 through 9, and assign
each number to a list element. (Random numbers were discussed in Chapter 5.)
Then write another loop that displays the contents of the list.'''
import random

def gen_lottery():
    numbers = []
    for i in range(7):
        numbers.append(random.randint(0,9))
    return numbers

def main():
    lottery_num = gen_lottery()
    print('Lottery Numbers:')
    count=0
    
    '''for i in lottery_num:
        print('{}'.format(i),end='')
        count+=1
        if count != 7:
            print(',',end='') # need help to omit last comma at last element'''
    
    print(",".join(str(i) for i in lottery_num))
    print(','.join(map(str, lottery_num)))
    
    input()
    
main()
