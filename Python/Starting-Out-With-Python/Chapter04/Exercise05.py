'''noonz
Average Rainfall
Write a program that uses nested loops to collect data and calculate the average
rainfall over a period of years. The program should first ask for the number of
years. The outer loop will iterate once for each year. The inner loop will
iterate twelve times, once for each month. Each iteration of the inner loop will
ask the user for the inches of rainfall for that month. After all iterations,
the program should display the number of months, the total inches of rainfall,
and the average rainfall per month for the entire period.'''
def get_years():
    years = int(input('Enter number of years: '))
    return years

def main():
    years = get_years()
    months = 12
    rainfall = []
    for i in range(years):
        for y in range(months):
            rain = int(input('Enter rain for month {}: '.format(y+1)))
            rainfall.append(rain)
    print('\nNumber of months: {}'.format(years*months))
    print('Total inches of rainfall: {}'.format(sum(rainfall)))
    print('Average rainfall per month: {:.2f}'
          .format(sum(rainfall)/(years*months)),end='')
    input()

main()
