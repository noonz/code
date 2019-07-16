'''noonz
Character Analysis
Use 'text.txt' for this exercise. Write a program that reads the file's contents
and determines the following:
- The number of uppercase letters
- The number of lowercase letters
- The number of digits
- The number of whitespace characters'''
def get_uppercase():
    upper_letters = 0
    with open('text.txt','r') as f:
        for i in f.read():
            if i.isupper():
                upper_letters += 1
    return upper_letters

def get_lowercase():
    lower_letters = 0
    with open('text.txt','r') as f:
        for i in f.read():
            if i.islower():
                lower_letters += 1
    return lower_letters

def get_digits():
    digits = 0
    with open('text.txt','r') as f:
        for i in f.read():
            if i.isdigit():
                digits += 1
    return digits

def get_whitespace():
    whitespace = 0
    with open('text.txt','r') as f:
        for i in f.read():
            if i.isspace():
                whitespace += 1
    return whitespace

def main():
    upper_letters = get_uppercase()
    lower_letters = get_lowercase()
    digits = get_digits()
    whitespace = get_whitespace()
    print('Upper letters: {}'.format(upper_letters))
    print('Lower letters: {}'.format(lower_letters))
    print('Digits: {}'.format(digits))
    print('Whitespaces: {}'.format(whitespace),end='')
    input()

main()
        
