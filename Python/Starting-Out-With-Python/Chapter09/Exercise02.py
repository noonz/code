'''noonz
Capital Quiz
Write a program that creates a dictionary containing the Canadian provinces as
keys, and their capitals as values. The program should then randomly quiz the
user by displaying the name of a state and asking the user to enter that
province's capital. The program should keep a count of the number of correct and
incorrect responses.'''
import random

prov_caps = {
'Alberta':'Edmonton',
'British Columbia':'Victoria',
'Manitoba':'Winnipeg',
'New Brunswick':'Fredericton',
'Newfoundland':'St. John\'s',
'Nova Scotia':'Halifax',
'Ontario':'Toronto',
'P.E.I.':'Charlottetown',
'Quebec':'Quebec City',
'Saskatchewan':'Regina'
    }

def get_keys():
    keys = list(prov_caps.keys())
    return keys

def ask_questions(keys):
    correct = 0
    random.shuffle(keys)
    for key in keys:
        ans = input(f'Enter capital for {key}: ')
        if ans.lower() == prov_caps[key].lower():
            correct += 1
    return correct

def main():
    keys = get_keys()
    correct = ask_questions(keys)
    print('you got {}/{}'.format(correct,len(keys)))
    input()
    
main()
