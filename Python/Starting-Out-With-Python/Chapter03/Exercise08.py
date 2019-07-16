'''noonz
Hot Dog Cookout Calculator
Assume hot dogs come in packages of 10, and hot dog buns come in packages of 8.
Write a program that calculates the number of packages of hot dogs and the
number of packages of hot dog buns needed for a cookout, with the minimum
amount of leftovers. The program should ask the user for the number of people
attending the cookout and the number of hot dogs each person will be given.
The program should display the following details:
- The minimum number of packages of hot dogs required
- The minimum number of packages of hot dog buns required
- The number of hot dogs that will be left over
- The number of hot dog buns that will be left over'''
HOTDOG_PACKS = 10
BUN_PACKS = 8

def get_people():
    people = int(input('Enter number of people attending: '))
    return people

def get_hotdogs_per_person():
    hotdogs = int(input('How many hotdogs will each person eat?: '))
    return hotdogs

def get_total(people,hotdogs):
    return people * hotdogs

def get_hotdogpack_total(total):
    if total / HOTDOG_PACKS == total // HOTDOG_PACKS:
        return total // HOTDOG_PACKS
    else:
        return total // HOTDOG_PACKS +1

def get_bunpack_total(total):
    if total / BUN_PACKS == total // BUN_PACKS:
        return total // BUN_PACKS
    else:
        return total // BUN_PACKS +1

def get_hotdog_leftovers(total):
    if total / HOTDOG_PACKS == total // HOTDOG_PACKS:
        return 0
    else:
        return HOTDOG_PACKS - total % HOTDOG_PACKS

def get_bunpack_leftovers(total):
    if total / BUN_PACKS == total // BUN_PACKS:
        return 0
    else:
        return BUN_PACKS - total % BUN_PACKS

def main():
    people = get_people()
    hotdogs = get_hotdogs_per_person()
    total = get_total(people,hotdogs)
    print('\nMinimum hotdog packs required: {}'
          .format(get_hotdogpack_total(total)))
    print('Minimum bun packs required: {}'.format(get_bunpack_total(total)))
    print('leftover hotdogs: {}'.format(get_hotdog_leftovers(total)))
    print('leftover buns: {}'.format(get_bunpack_leftovers(total)))
    input()

main()
