'''noonz
String Repeater
Python allows you to repeat a string by multiplying it by an integer, eg.
'Hi' * 3 will give 'HiHiHi'. Pretend that this feature does not exist, and
instead write a function named repeat that accepts a string and an integer as
arguments. The function should return a string of the original string repeated
the specific number of times, eg. repeat('hi',3) should return 'hihihi'.'''
def repeat(string,num):
    return string * num

def get_string():
    string = input('Enter a string to be repeated: ')
    return string

def get_num():
    num = int(input('Enter times to be repeated: '))
    return num

def main():
    string = get_string()
    num = get_num()
    print(repeat(string,num),end='')
    input()

main()
