'''noonz
File Display
Assume a file containing a series of integers is named numbers.txt and exists
on the computer's disk. Write a program that displays all of the numbers in the
file.'''
def main()
    f = open('numbers.txt','r')
    print(f.read())
    f.close()
    input()
    
main()
