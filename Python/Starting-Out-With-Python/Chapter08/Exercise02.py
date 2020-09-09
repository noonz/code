'''noonz
Sum of Digits in a String
Write a program that asks the user to enter a series of single-digit numbers
with nothing separating them. The program should display the sum of all the
single digit numbers in the string. For example, if the user enters 2514, the
method should return 12, which is the sum of 2,5,1,4.'''
def get_string():
    my_string = input('Enter numbers: ')
    return my_string

def get_string_sum(string):
    string_sum = 0
    for ch in string:
        string_sum += int(ch)
    return string_sum

def main():
    my_string = get_string()
    string_sum = get_string_sum(my_string)

    print('The sum of your string is: {}'.format(string_sum),end='')
    input()

main()