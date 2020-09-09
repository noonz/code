'''noonz
How Much Insurance?
Many financial experts advise that property owners should insure their homes
or buildings for at least 80 percent of the amount it would cost to replace
the structure. Write a progrm that asks the user to enter the replacement
cost of a building, then displays the minimum amount of insurance he or she
should buy for the property.'''
def get_cost():
    cost = int(input('Enter building replacement cost: $'))
    return cost

def get_insurance(cost):
    return cost * .8

def main():
    cost = get_cost()
    insurance = get_insurance(cost)
    print('Cost: ${:,.2f}\nInsurnace(80%): ${:,.2f}'.format(cost,insurance))
    input()

main()
