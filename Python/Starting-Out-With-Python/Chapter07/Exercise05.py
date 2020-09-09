'''noonz
Charge Account Validation
Use charge_accounts.txt for this exercise. This file has a list of a company's
valid charge account numbers. Each account number is a seven-digit number, such
as 5658845. Write a program that reads the contents of the file into a list. The
program should then ask the user to enter a charge account number. The program
should determine whether the number is valid by searching for it in the list. If
the number is in the list, the program should display a message indicating the
number is valid. If the number is not in the list, the program should display a
message indicating the number is invalid.'''
def get_acnt():
    acnt = int(input('Enter a 7 digit account number: '))
    return acnt

def get_validity(acnt,charge_acnts):
    for i in charge_acnts:
        if i in charge_acnts:
            return 'Valid account.'
        else:
            return 'Invalid account.'

def main():
    charge_acnts = []
    acnt = get_acnt()
    
    with open('charge_accounts.txt','r') as f:
        for i in f:
            charge_acnts.append(i.strip('\n'))
            
    print(get_validity(acnt,charge_acnts),end='')
    input()
    
main()
