'''noonz
Kilometer Converter
Write a program that asks the user to enter a distance in kilometers, then
converts that distance into miles. The conversion formula is as follows:
Miles = Kilometers * 0.6214'''
def get_kilometers():
    k = int(input('Enter kilometers: '))
    return k

def convert_to_miles(kilometers):
    return kilometers * 0.6214

def main():
    kilometers = get_kilometers()
    miles = convert_to_miles(kilometers)
    print('{:.0f}km = {:.0f}miles'.format(kilometers,miles),end='')
    input()

main()
