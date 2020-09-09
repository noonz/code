'''noonz
File Analysis
Write a program that reads the contents of two text files and compares them in
the following ways. It should display a list of the following:
-All the unique words contained in both files
-Words that appear in both files
-Words that appear in the first file but not the second
-Words that appear in the second file but not the first
-Words that appear in either the first or second file, but not both
Hint: Use set operations to perform these analyses.
'''
file_one = 'Ch9_E6text_one.txt'
file_two = 'Ch9_E6text_two.txt'

def get_words(file_name):
    words = []
    with open(file_name,'r') as file:
        for line in file:
            word = line.strip('\n')
            words.append(word)
    return set(words)

def main():
    word_set_one = get_words(file_one)
    word_set_two = get_words(file_two)
    matched_words = ', '.join(word_set_one.intersection(word_set_two))
    set_one_words = ', '.join(word_set_one.difference(word_set_two))
    set_two_words = ', '.join(word_set_two.difference(word_set_one))
    distinct_words = ', '.join(word_set_one.symmetric_difference(word_set_two))
    print('Matched words in both files: {}'.format(matched_words))
    print('Set one words: {}'.format(set_one_words))
    print('Set two words: {}'.format(set_two_words))
    print('Distinct words: {}'.format(distinct_words))
    
main()
