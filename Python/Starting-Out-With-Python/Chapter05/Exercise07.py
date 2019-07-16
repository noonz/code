'''noonz
Stadium Seating
There are three seating categories at a stadium. Class A seats cost $20, Class B
seats cost $15, and Class C seats cost $10. Write a program that asks how many
tickets for each class of seats were sold, then displays the amount of income
generated from ticket sales.'''
CLASS_A = 20
CLASS_B = 15
CLASS_C = 10

def get_class_a():
    a_tickets = int(input('How many Class A tickets sold?: '))
    return a_tickets

def get_class_b():
    b_tickets = int(input('How many Class B tickets sold?: '))
    return b_tickets

def get_class_c():
    c_tickets = int(input('How many Class C tickets sold?: '))
    return c_tickets

def main():
    a_tickets = get_class_a()
    b_tickets = get_class_b()
    c_tickets = get_class_c()
    print('Class A ticket profit: ${:,.2f}'.format(a_tickets * CLASS_A))
    print('Class B ticket profit: ${:,.2f}'.format(b_tickets * CLASS_B))
    print('Class C ticket profit: ${:,.2f}'.format(c_tickets * CLASS_C),end='')
    input()

main()
