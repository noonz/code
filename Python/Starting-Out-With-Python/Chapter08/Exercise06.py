'''noonz
Average Number of Words
Use 'text.txt' for this exercise. The text that is in the file is stored as one
sentence per line. Write a program that reads the file's contents and calculates
the average number of words per sentence.'''
def words_to_list():
    word_list = []
    with open('text.txt','r') as f:
        for ch in f:
            word_list.append(ch.strip('\n').split(' '))
    return word_list

def get_averages(word_list):
    avg_1 = 0
    avg_2 = 0
    avg_3 = 0
    avg_4 = 0
    avg_5 = 0

    for line in word_list[0]:
        for word in line:
            avg_1 += len(word)
    for line in word_list[1]:
        for word in line:
            avg_2 += len(word)
    for line in word_list[2]:
        for word in line:
            avg_3 += len(word)
    for line in word_list[3]:
        for word in line:
            avg_4 += len(word)
    for line in word_list[4]:
        for word in line:
            avg_5 += len(word)
    return avg_1,avg_2,avg_3,avg_4,avg_5

def main():
    word_list = words_to_list()
    avg_1,avg_2,avg_3,avg_4,avg_5 = get_averages(word_list)
    print('Sentence 1 average word length: {:.0f}'
          .format(avg_1/len(word_list[0])))
    print('Sentence 2 average word length: {:.0f}'
          .format(avg_2/len(word_list[1])))
    print('Sentence 3 average word length: {:.0f}'
          .format(avg_3/len(word_list[2])))
    print('Sentence 4 average word length: {:.0f}'
          .format(avg_3/len(word_list[3])))
    print('Sentence 5 average word length: {:.0f}'
          .format(avg_3/len(word_list[4])),end='')
    input()

main()
