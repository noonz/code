'''noonz
Calories Burned
Running on a particular treadmill you burn 4.2 calories per minute. Write a
program that uses a loop to display the number of calories burned after
10, 15, 20, 25, and 30 minutes.'''
BURNED_CALS = 4.2
DISPLAY = [10,15,20,25,30]

def main():
    print('Burning 4.2 calories per minute...')
    for i in range(30):
        if i+1 in DISPLAY:
            print('You burned {:.0f} calories in {} minutes.'
                  .format(BURNED_CALS * (i+1),i+1))
    input()

main()
