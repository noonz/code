'''noonz
Name Search
Use these files:
-GirlNames.txt: This file contains a list of the 200 most popular names given to
girls born in the US from the year 2000 through 2009
-BoyNames.txt: This file contains a list of the 200 most popular names given to
boys born in the US from the year 2000 through 2009
Write a program that reads the contents of the two files into two separate
lists. The user should be able to enter a boy's name, a girl's name, or both,
and the application will display messages indicating whether the names were
among the most popular.'''
def get_girl_names():
    girl_names = []
    with open('GirlNames.txt','r') as f:
        for i in f:
            girl_names.append(i.strip('\n'))
    return girl_names

def get_boy_names():
    boy_names = []
    with open('BoyNames.txt','r') as f:
        for i in f:
            boy_names.append(i.strip('\n'))
    return boy_names

def get_name():
    name = input('Search name or [enter] to quit: ')
    return name

def check_names(girl_names,boy_names,name):
    if name in girl_names:
        print('{} is a popular girl name.'.format(name))
    elif name in boy_names:
        print('{} is a popular boy name.'.format(name))
    else:
        print('{} isn\'t a popular name.'.format(name))

def main():
    girl_names = get_girl_names()
    boy_names = get_boy_names()

    while True:
        name = get_name()
        if name == '':
            break
        check_names(girl_names,boy_names,name)

main()
