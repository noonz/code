'''noonz
Number Analyser
Write a program that asks the user to enter an integer. The program should
display 'Positive' if the number is greater than 0, 'Negative' if the number
is less than 0, and 'Zero' if the number is equal to 0. The program should
then display 'Even' if the number is even, or 'Odd' if the number is odd.'''
def get_num():
    num = int(input('Enter a number: '))
    return num

def check_number(num):
    if num > 0:
        return 'Positive'
    elif num < 0:
        return 'Negative'
    else:
        return 'Zero'

def check_odd_even(num):
    if num % 2 == 0:
        return 'Even'
    else:
        return 'Odd'

def main():
    num = get_num()
    status = check_number(num)
    odd_even = check_odd_even(num)
    print('{} is {} and is an {} number.'.format(num,status,odd_even),end='')
    input()

main()
