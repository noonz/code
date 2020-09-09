'''noonz
Pennies for Pay
Write a program that calculates the amount of money a person would earn over a
period of time if his or her salary is one penny the first day, two pennies the
second day, and continues to double each day. The program should ask the user
for the number of days. Display a table showing what the salary was for each day
then show the total pay at the end of the period. The output should be displayed
in a dollar amount, not the number of pennies.'''
def get_days():
    days = int(input('Enter number of days: '))
    return days

def main():
    balance = 0.00
    days = get_days()
    print('Days           Balance')
    print('----------------------')
    for i in range(days):
        if balance == 0.00:
            balance += 0.01
        print('{:3d}             ${:,.2f}'.format(i+1,balance))
        balance *= 2
    input()

main()
        
