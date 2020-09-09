'''noonz
Payment Instalments
Write a program that asks the user to enter the amount of a purchase and the
desired number of payment instalments. The program should add 5 percent to the
amount to get the total purchase amount, and then divide it by the desired
number of instalments, then display messages telling the user the total amount
of the purchase and how much each instalment will cost.'''
def get_purchase():
    purchase = int(input('Enter purchase amount: $'))
    return purchase

def get_instalments():
    instalments = int(input('Enter desired instalments: '))
    return instalments

def get_total(purchase):
    return purchase * 1.05

def main():
    purchase = get_purchase()
    instalments = get_instalments()
    total = get_total(purchase)
    print('Your total is ${:.2f}'.format(total))
    print('Your monthly payments are ${:.2f}'.format(total/instalments),end='')
    input()

main()
    
