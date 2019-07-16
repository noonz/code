'''noonz
Word List File Writer
Write a program that asks the user how many words they would like to write to a
file, and then asks the user to enter that many words, one at a time. The words
should be written to a file.'''
def get_word_count():
    count = int(input('How many words do you want to write?: '))
    return count

def main():
    word_count = get_word_count()
    with open('word_list.txt','w+') as f:
        for line in range(word_count):
            write_line = input('Enter a word: ')
            f.write(write_line+'\n')
    input('Saved to \'word_list.txt\'')
    
main()
