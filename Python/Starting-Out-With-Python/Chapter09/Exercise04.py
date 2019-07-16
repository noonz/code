'''noonz
Unique Words
Write a program that opens a specified text file then displays a list of all the
unique words found in the file.'''
word_dict = {}

def get_words():
    with open('Ch9_E4text.txt','r') as file:
        for line in file:
            words = line.strip('\n').replace('.','').replace(',','').split(' ')
            for word in words:       
                if word.lower() not in word_dict:
                    word_dict[word.lower()] = 1
                else:
                    word_dict[word.lower()] += 1

get_words()

for k,v in word_dict.items():
    print('-{} : {}'.format(k,v))

input()
