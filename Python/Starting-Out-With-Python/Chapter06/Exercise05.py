'''noonz
Sum of Numbers
Assume a file containing a series of inegers is named numbers.txt and exists on
the computer's disk. Write a program that reads all of the numbers stored in the
file and calculates their total.'''
def main():
    total = 0
    count = 0
    with open('numbers.txt','r') as f:
        for line in f:
            print(line,end='')
            total += int(line.strip('\n'))
            count += 1
    print('\n\nNumbers: {}\nSum: {}'.format(count,total),end='')
    input()

main()
