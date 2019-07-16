'''noonz
Tip, Tax, and Total
Write a program that calculates the total amount of a meal purchased at a
restaurant. The program should ask the user to enter the charge for the food,
then calculate the amounts of a 18 percent tip and 7 percent sales tax.
Display each of these amount and the total.'''
def get_charge():
    charge = float(input('Enter food cost: $'))
    return charge

def get_tip(charge):
    return charge * .18

def get_sales_tax(charge):
    return charge * 0.07

def get_total(charge,tip,sales_tax):
    return charge+tip+sales_tax

def main():
    charge = get_charge()
    tip = get_tip(charge)
    sales_tax = get_sales_tax(charge)
    total = get_total(charge,tip,sales_tax)
    print('Cost: ${:.2f}\nTip(18%): ${:.2f}\nTax(7%): ${:.2f}\n\
Total: ${:.2f}'.format(charge,tip,sales_tax,total),end='')
    input()

main()
