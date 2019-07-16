'''noonz
Galilean Moons of Jupiter
Write a program that creates a dictionary containing the names of the Galilean
moons of Jupiter as keys and their mean radiuses (in KM) as values. The
dictionary should contain the following key-value pairs:
Moon Name (key)    Mean Radius (value)
Io                 1821.6
Europa             1560.8
Ganymede           2634.1
Callisto           2410.3
The program should also create a dictionary containing the moon names and their
surface gravities (in meters per second squared). The dictionary should contain
the following key value pairs:
Moon Name (key)    Surface Gravity (value)
Io                 1.796
Europa             1.314
Ganymede           1.428
Callisto           1.235
The program should also create a dictionary contaiing the moon names and their
orbital periods (in days). The dictionary should contain the following
key-value pairs:
Moon Name (key)    Orbital Period (value)
Io                 1.769
Europa             3.551
Ganymede           7.154
Callisto          16.689
The program should let the user enter the name of a Galilean moon of Jupiter,
then it should display the moon's mean radius, surface gravity, and orbital
period.'''
moon_radius = {
'io':1821.6,
'europa':1560.8,
'ganymede':2634.1,
'callisto':2410.3
    }
moon_gravity = {
'io':1.796,
'europa':1.314,
'ganymede':1.428,
'callisto':1.235
    }
moon_orbital = {
'io':1.769,
'europa':3.551,
'ganymede':7.154,
'callisto':16.689
    }

def get_moon():
    moon = input('Enter a moon of Jupiter: ')
    return moon

def display_info(moon):
    print('\nInfo. for {}'.format(moon))
    print('----------------')
    print('Radius {}\nGravity {}\nOrbital {}'
          .format(moon_radius[moon.lower()],
                  moon_gravity[moon.lower()],moon_orbital[moon.lower()]))

def main():
    print('Moons of Jupiter')
    print('----------------')
    print('Io\nEurope\nGanymede\nCallisto')
    moon = get_moon()
    display_info(moon)
    input()

main()
