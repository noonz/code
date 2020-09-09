'''Noonz
Pounds to Kilograms
One pound is equivalent to 0.454 kilograms. Write a program that asks the user
to enter the mass of an object in pounds and then calculates and displays
the mass of the object in kilograms'''

def get_pounds():
    pounds = int(input('Enter mass in pounds: '))
    return pounds

def convert_to_kilos(pounds):
    return pounds * 0.454

def main():
    pounds = get_pounds()
    kilos = convert_to_kilos(pounds)
    print('{} pounds = {} kilos'.format(pounds,int(kilos)),end='')
    input()

main()
