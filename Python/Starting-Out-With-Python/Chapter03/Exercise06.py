'''noonz
Magic Dates
The date June 10, 1960, is special because when it is written in the following
format, the month times the day equals the year:
6/10/60
Design a program that asks the user to enter a month (in numeric form), a day,
and a two-digit year. The program should then determine whether the month times
the day equals the year. If so, it should display a message saying the date
is magic. Otherwise, it should display a message saying the date is not magic.'''
def check_magic(day,month,year):
    if day*month == year:
        return 'this is a magic date'
    else:
        return 'this date is not magic'

def get_date():
    day = int(input('Enter a day: '))
    month = int(input('Enter a month: '))
    year = int(input('Enter a two digit year: '))
    return day,month,year

def main():
    day,month,year = get_date()
    print(check_magic(day,month,year),end='')
    input()

main()
