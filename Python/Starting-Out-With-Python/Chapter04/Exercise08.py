'''noonz
Average Word Length
Write a program with a loop that repeatedly asks the user to enter a word. The
user should enter nothing (press Enter without typing anything) to signal the
end of the loop. Once the loop ends, the program should display the average
length of the words entered, rounded to the nearest whole number.'''
def main():
    letter_count = 0
    word_count = 0
    while True:
        word = input('Type a word or enter to exit: ')
        if word == '':
            break
        letter_count += len(word)
        word_count += 1
    print('\nTotal words: {}'.format(word_count))
    print('Average length of words: {:.0f}'.format(letter_count/word_count))

main()
