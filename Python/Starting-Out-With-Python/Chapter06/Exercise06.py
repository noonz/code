'''noonz
Average of Numbers
Assume a file containing a series of integers is named numbers.txt and exists on
the computer's disk. Write a program that calculates the average of all the
numbers stored in the file.'''
def main():
    total = 0
    count = 0
    with open('numbers.txt','r') as f:
        for line in f:
            print(line,end='')
            total += int(line.strip('\n'))
            count += 1
    print('\n\nNumbers: {}\nAverage: {}'.format(count,total/count),end='')
    input()

main()
