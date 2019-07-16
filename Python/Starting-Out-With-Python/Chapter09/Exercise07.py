'''noonz
World Series Winners
Use Ch9_E7text.txt for this exercise. This file contains a chronological list
of the World Series' winning teams from 1903-2009. (Note the World Series was
not played in 1904 or 1994. There are entries stating this.
Write a program that reads this file and creates a dictionary in which the keys
are the names of the teams, and each key's associated value is the number of
times the team has won the World Series. The program should also create a
dictionary in which the keys are the years, and each key's assoicated value
is the name of the team that won that year.
The program should prompt the user for a year in the range of 1903-2009. It
should then display the name of the team that won the World Series that year,
and the number of times that team has won the World Series.'''
def get_team_wins():
    winner_dict = {}
    with open('Ch9_E7text.txt','r') as f:
        for line in f:
            winner = line.strip('\n')
            if winner in winner_dict:
                winner_dict[winner] += 1
            else:
                winner_dict[winner] = 1
    return winner_dict

def get_year_winner():
    winner_year = {}
    start_year = 1903
    with open('Ch9_E7text.txt','r') as f:
        for line in f:
            winner = line.strip('\n')
            winner_year[start_year] = winner
            start_year += 1
    return winner_year

def main():
    winner_dict = get_team_wins()
    winner_year = get_year_winner()
    while True:
        user_choice = int(input('Enter a year between 1903-2009: '))
        if user_choice not in range(1903,2010):
            continue
        else:
            print('{} won {} time(s) between 1903-2009.'
                  .format(winner_year[user_choice],
                  winner_dict[winner_year[user_choice]]))
            break
    input()

main()
