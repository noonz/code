'''noonz
Number Analysis Program
Design a program that asks the user to enter a series of 7 numbers. The program
should store the numbers in a list then display the following data:
-Lowest number
-Highest number
-Sum of numbers
-Average of the numbers'''
def get_numbers():
    numbers = []
    for i in range(7):
        num = int(input('Enter number: '))
        numbers.append(num)
    return numbers

def main():
    num_list = get_numbers()
    print('Lowest number: {}'.format(min(num_list)))
    print('Highest number: {}'.format(max(num_list)))
    print('Sum of numbers: {}'.format(sum(num_list)))
    print('Average of numbers: {:.0f}'.format(sum(num_list)/len(num_list)),end='')
    input()

main()
