'''noonz
Automobile Costs
Write a program that asks the user to enter the monthly costs for the following
expenses incurred from operating his or her automobile: loan payment, insurance,
gas, oil, tires, and maintenance. The program should then display the total
monthly cost of these expenses, and the total annual cost of these expenses.'''
expenses = ['loan','insurance','gas','oil','tires','maintenance']

def get_prices(expenses):
    costs = 0
    for i in expenses:
        cost = float(input('Cost for {}: $'.format(i)))
        costs += cost
    return costs

def main():
    print('Car expenses')
    print('------------')
    costs = get_prices(expenses)
    print('\nMonthly expenses: ${:,.2f}'.format(costs))
    print('Yearly expenses: ${:,.2f}'.format(costs*12),end='')
    input()

main()
