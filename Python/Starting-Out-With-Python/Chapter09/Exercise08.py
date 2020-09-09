'''noonz
Pickled Vegetables
Write a program that keeps vegetable names and prices in a dictionary as
key-value pairs. The program should display a menu that lets the user see a list
of all vegetables and their prices, add a new vegetable and price, change the
price of an existing vegetable, and delete an existing vegetable and price.
The program should pickle the dictionary and save it to a file when the user
exits the program. Each time the program starts, it should retrieve the
dictionary from the file and unpickle it.'''
import pickle

def display_menu():
    print('Menu\n-------------------')
    for k,v in store_items.items():
        print('{}${}'.format(k.ljust(15),v))

try:
    with open('Ch9_E8text.txt','rb') as f:
        store_items = pickle.load(f)
        display_menu()
except IOError:
    print('No items stored.')
    store_items = {}

def get_user_choice():
    print('\n1. Add entry\n2. Edit Entry\n3. Delete Entry\n4. Save & Exit\n\
5. Menu')
    while True:
        user_choice = int(input('Choose an option: '))
        if user_choice in range(1,6):
            break
    return user_choice

def add_entry():
    entry_name = input('Enter name of item: ')
    entry_price = int(input('Enter price of item: $'))
    store_items[entry_name] = entry_price

def edit_entry():
    entry_name = input('Enter name of item to edit: ')
    entry_price = int(input('Enter new price: $'))
    for k in store_items:
        if entry_name.lower() in k.lower():
            store_items[k] = entry_price
            print('Item updated.')

def delete_entry():
    entry_name = input('Enter name of item to delete: ')
    for k in store_items:
        if entry_name.lower() in k.lower():
            del store_items[k]
            print('{} removed from menu.'.format(entry_name))
            break
        
def main():
    while True:
        user_choice = get_user_choice()
        if user_choice == 1:
            add_entry()
        elif user_choice == 2:
            edit_entry()
        elif user_choice == 3:
            delete_entry()
        elif user_choice == 4:
            with open('Ch9_E8text.txt','wb') as f:
                pickle.dump(store_items,f)
            break
        elif user_choice == 5:
            print()
            display_menu()
    input('cy@')

main()
