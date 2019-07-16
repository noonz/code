'''noonz
Name Display
Write a program that gets strings containing a person's first and last name as
separate values, and then displays their 'initials', 'name in address book', and
'username'. For example, if the user enteres a first name of 'John' and a last
name of 'Smith', the program should display 'J.S.','John SMITH', and jsmith.'''
def get_names():
    first_name  = input('Enter first name: ')
    last_name = input('Enter last name: ')
    return first_name,last_name

def get_user_name(first_name,last_name):
    return  first_name[0].lower() + last_name.lower()

def get_initials(first_name,last_name):
    return first_name[0].upper() + '.' + last_name[0].upper()+ '.'

def get_address_name(first_name,last_name):
    return first_name + ' ' + last_name.upper()

def main():
    first_name,last_name = get_names()
    user_name = get_user_name(first_name,last_name)
    initials = get_initials(first_name,last_name)
    address_name = get_address_name(first_name,last_name)
    print('\nIntials: {}'.format(initials))
    print('Name in Address book: {}'.format(address_name))
    print('Username: {}'.format(user_name))
    input()

main()