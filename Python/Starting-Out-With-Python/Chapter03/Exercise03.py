'''noonz
Quarter of the Year
Write a program that asks the user for a month as a number between 1 and 12.
The program should display a message indicating whether the month is in the
first quarter, the second quarter, the third quarter, or the fourth quarter of
the year. Following are the guidelines:
-1-3 first quarter
-4-6 second quarter
-7-9 third quarter
-10-12 fourth quarter
-not between 1-12, display an error'''
def get_number():
    while True:
        num = int(input('Enter a number of a month: '))
        if num not in range(1,13):
            print('use 1-12')
        else:
            break
    return num

def get_quarter(num):
    if num in range(1,4):
        return 'first quarter'
    elif num in range(4,7):
        return 'second quarter'
    elif num in range(7,10):
        return 'third quarter'
    else:
        return 'fourth quarter'

def main():
    num = get_number()
    print('Your month is in the {}.'.format(get_quarter(num)),end='')
    input()

main()
