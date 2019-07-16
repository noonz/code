'''noonz
Word List File Reader
This exercise assumes you have completed the Programming Exercise 7, Word List
File Writer. Write another program that reads the words from the file and
displays the following data:
-Number of words in the file.
-Longest word in the file.
-Average length of all the words in the file.'''
def main():
    word_list = []
    ch_count = 0
    longest_word = ''
    
    with open('word_list.txt','r') as f:
        for line in f:
            word_list.append(line.strip('\n'))
            for ch in line.strip('\n'):
                ch_count += 1

    for i in word_list:
        if len(i) > len(longest_word):
            longest_word = i

    print('Number of words: {}'.format(len(word_list)))
    print('Longest word: {}'.format(longest_word))
    print('Average word length: {:.0f}'.format(ch_count/len(word_list)),end='')
    input()

main()
