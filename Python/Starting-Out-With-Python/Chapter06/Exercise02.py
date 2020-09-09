'''noonz
File Head Display
Write a program that asks the user for the name of a file. The program should
display only the first five lines of the file's contents. If the file contains
less than five lines, it should display the file's entire contents.'''
def get_file():
    file = input('Enter file name to open(use numbers.txt): ')
    return file

def main():
    file_name = get_file()
    f = open(file_name,'r')
    
    count = 0
    while count != 5:
        print(f.readline(),end='')
        count += 1
    f.close()

main()
