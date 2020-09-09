'''noonz
Roman Numerals
Write a program that prompts the user to enter a number within the range of
1 through 10. The program should display the Roman numeral version of that
number. If the number is outside the range of 1 through 10, the program
should display an error message. The following table shows the Roman numerals
for numbers 1 through 10:
- 1 --> I
- 2 --> II
- 3 --> III
- 4 --> IV
- 5 --> V
- 6 --> VI
- 7 --> VII
- 8 --> VIII
- 9 --> IX
- 10 --> X'''
roman_nums = {1:'I',2:'II',3:'III',4:'IV',5:'V',6:'VI',7:'VII',8:'VIII',
              9:'IX',10:'X'}

def get_number():
    while True:
        num = int(input('Enter a number: '))
        if num not in range(1,11):
            print('use numbers 1-10')
        else:
            break
    return num

def main():
    num = get_number()
    print('{}\'s roman numeral is: {}'.format(num,roman_nums[num]),end='')
    input()

main()
