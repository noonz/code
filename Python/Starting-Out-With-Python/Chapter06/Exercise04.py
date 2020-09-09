'''noonz
High Score
Assume tht a file named scores.txt exists on the computer's disk. It contains
a series of records, each with two fields - a name, followed by a score. (an
integer between 1 and 100). Write a program that displays the name and score
of the record with the highest score, as well as the number of records in the
file. (Hint: Use a variable and an 'if' statement to keep track of the highest
score found as you read through the records, and a variable to keep count
of the number of records.)'''
def main():
    records = 0
    score_list = []
    high_score = 0
    
    with open('scores.txt','r') as f:
        for line in f:
            records += 1
            score_list.append(line.strip('\n').split(' '))

    print('Scores')
    print('---------')

    
    for name,score in score_list:
        print('{} ... {}'.format(name,score))
        if high_score < int(score):
            winner = name
            high_score = int(score)

    print('\nTotal records: {}'.format(records))
    print('High Score: {}\nHeld by: {}'.format(high_score,name),end='')
    input()

main()
