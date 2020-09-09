'''noonz
Mass and Weight
Scientists measure an object's mass in kilograms and its weight in newtons. If
you know the amount of mass of an object in kilograms, you can calculate its
weight in newtons with the following formula:
weight = mass * 9.8
Write a program that asks the user to enter an object's mass, then calculate
its weight. If the object weighs more than 500 newtons, display a message
indicating that it is too heavy. If the object weighs less than 100 newtons,
display a message indicating that is it too light.'''
def calc_newtons(mass):
    return mass * 9.8

def get_mass():
    mass = int(input('Enter object\'s mass: '))
    return mass

def check_weight(newtons):
    if newtons > 500:
        return 'too heavy.'
    elif newtons < 100:
        return 'too light.'
    else:
        return 'just right.'

def main():
    mass = get_mass()
    newtons = calc_newtons(mass)
    print('{:.0f}'.format(newtons))
    print('Your object is {}'.format(check_weight(newtons)),end='')
    input()

main()
    
