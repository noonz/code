'''noonz
Line Numbers
Write a program that asks the user for the name of a file. The program should
display the contents of the file with each line preceded with a line number
followed by a colon. The line numbering should start at 1.'''
def get_file():
    file = input('Enter file to read(use numbers.txt): ')
    return file

def main():
    file_name = get_file()
    f = open(file_name,'r')

    count = 1
    for line in f:
        print('Line {}: {}'.format(count,line),end='')
        count += 1
    f.close()

main()
