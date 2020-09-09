'''noonz
Bug Collector
A bug collector collects bugs every day for five days. Write a program that
keeps a running total of the number of bugs collect during the five days. The
loop should ask for the number of bugs collected for each day, and when the loop
is finished, the program should display the total number of bugs collected'''
def get_bugs():
    bugs = 0
    days = 5
    for i in range(days):
        collected = int(input('Enter bugs collected on day {}: '.format(i+1)))
        bugs += collected
    return bugs

def main():
    bugs = get_bugs()
    print('Bugs collected after 5 days: {}'.format(bugs),end='')
    input()

main()
