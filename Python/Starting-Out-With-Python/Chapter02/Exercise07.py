'''noonz
Miles-per-Gallon
A car's miles-per-galln (MPG) can be calculated with the following formula:
MPG = Miles driven / Gallons of gas used
Write a program that asks the user for the number of miles driven and the
gallons of gas used. It should calculate the car's MPG and display the result.'''
def get_mpg(miles,gallons):
    return miles / gallons

def get_miles():
    miles = int(input('Enter miles driven: '))
    return miles

def get_gallons():
    gallons = int(input('Enter gallons used: '))
    return gallons

def main():
    miles = get_miles()
    gallons = get_gallons()
    mpg = get_mpg(miles,gallons)
    print('Your car\'s MPG is: {}'.format(int(mpg)),end='')
    input()

main()
