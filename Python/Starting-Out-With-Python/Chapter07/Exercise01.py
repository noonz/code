'''noonz
Valid Number Information
Design a program that uses a loop to build a list named valid_numbers that
contains only the numbers between 0 and 100 from the numbers list below. The
program should then determine and display the total and average of the values
in the valid_numbers list.
numbers = [74,19,105,20,-2,67,77,124,-45,38]'''
numbers = [74,19,105,20,-2,67,77,124,-45,38]

def main():
    valid_numbers = []
    
    for i in numbers:
        if i in range(1,101):
            print('Valid: {}'.format(i))
            valid_numbers.append(i)
        else:
            print('Invalid: {}'.format(i))

    print('\nTotal: {}'.format(sum(valid_numbers)))
    print('Average: {:.2f}'.format(sum(valid_numbers)/len(valid_numbers),end=''))
    input()

main()
