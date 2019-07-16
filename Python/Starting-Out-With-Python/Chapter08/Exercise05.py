'''noonz
Alphabetic Telephone Number Translator
Many companies use telephone numbers like 555-GET-FOOD so the number is easier
for their customers to remember. On a standard telephone, the alphabetic letters
are mapped to the numbers in the following fashion:
A,B,C = 2
D,E,F = 3
G,H,I = 4
J,K,L = 5
M,N,O = 6
P,Q,R,S = 7
T,U,V = 8
W,X,Y,Z = 9
Write a program that asks the user to enter a 10-character telephone number in
the format XXX-XXX-XXXX. The application should display the telephone number
with any alphabetic characters that appeared in the original translated to their
equivalent. For example, if the user enters 555-GET-FOOD, the application should
display 555-438-3663.'''
number_dict = {
    2:('A','B','C'),3:('D','E','F'),4:('G','H','I'),5:('J','K','L'),
    6:('M','N','O'),7:('P','Q','R','S'),8:('T','U','V'),9:('W','X','Y','Z')
}

def get_number():
    number = input('Enter a phone number in format XXX-XXX-XXXX: ')
    return number

def convert_number(number):
    new_num = ''
    for ch in number.upper():
        if ch.isalpha():
            for k,v in number_dict.items():
                if ch in v:
                    new_num += str(k)
        else:
            new_num += ch
    return new_num


def main():
    number = get_number()
    new_num = convert_number(number)
    print('Converted number: {}'.format(new_num),end='')
    input()

main()