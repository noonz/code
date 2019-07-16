'''noonz
Paint Job Estimator
A painting company has determined that for every 112 square feet of wall space,
one gallon of paint and eight hours of labor will be required. The company
charges $35.00 per hour for labor. Write a program that asks the user to enter
the square feet of wall space to be painted and the price of the paint per
gallon. The program should display the following data:
- Number of gallons of paint required
- Hours of labor required
- Cost of the paint
- Labor charges
- Total cost of the paint job'''
def get_squareft():
    squareft = int(input('Enter square ft.: '))
    return squareft

def get_gallon_price():
    g_price = int(input('Enter price of paint per gallon: $'))
    return g_price

def get_labor_hours(squareft):
    return squareft // 112 * 8 + 1

def get_gallons_paint(squareft):
    if squareft % 112 == 0:
        return squareft // 112
    else:
        return squareft // 112 + 1

def get_labor_costs(labor_hours):
    return labor_hours * 35

def main():
    squareft = get_squareft()
    gallon_price = get_gallon_price()
    labor_hours = get_labor_hours(squareft)
    gallons_paint = get_gallons_paint(squareft)
    labor_costs = get_labor_costs(labor_hours)
    print('\nGallons of paint required: {:.0f}'.format(gallons_paint))
    print('Hours of labor required: {:.0f}'.format(labor_hours))
    print('Cost of paint: ${:,.2f}'.format(gallon_price * gallons_paint))
    print('Labor charges: ${:,.2f}'.format(labor_costs))
    print('Total job costs: ${:,.2f}'
          .format(labor_costs + (gallon_price*gallons_paint)),end='')
    input()

main()
