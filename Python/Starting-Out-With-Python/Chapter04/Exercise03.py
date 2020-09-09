'''noonz
Lap Times
Write a program that asks the user to enter the number of times that they have
run around a racetrack, and then uses a loop to prompt them to enter the lap
time for each of their laps. When the loop finishes, the program should display
the time of their fastest lap, the time of their slowest lap, and their average
lap time.'''
def get_laps():
    laps = int(input('Enter laps around the track: '))
    return laps

def get_lap_times(laps):
    times = []
    for i in range(laps):
        time = input('Enter time for lap {}: '.format(i+1))
        times.append(time)
    return times

def convert_to_float(times):
    float_time = []
    for i in times:
        time = i.replace(':','.')
        float_time.append(float(time))
    return float_time

def main():
    laps = get_laps()
    times = get_lap_times(laps)
    float_time = convert_to_float(times)
    print('\nLap times\n----------')
    for i in times:
        print(i)
    print('\nYour fastest lap is {:.2f} mins.'.format(min(float_time)))
    print('Your slowest lap is {:.2f} mins.'.format(max(float_time)))
    print('Your average lap time is {:.2f} mins'.format(sum(float_time)/laps))
    input()

main()
