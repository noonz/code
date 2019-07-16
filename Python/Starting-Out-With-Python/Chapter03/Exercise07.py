'''noonz
Grade Calculator
A class has two tests worth 25 points each along with a main exam worth 50 pnts.
For a student to pass the class, they must obtain an overall score of at least
50 points, and must obtain at least 25 points in the main exam. If a student's
total score is less than 50 or they obtain less than 25 points in the main exam,
they receive a grade of 'Fail'. Otherwise, their grade is as follows:
- If they get grade >80, they get 'Distinction'. 50-59 = 'Pass'
- If they get <80, but more than 60, they get 'Credit'.
- If they get <60, they get a 'Pass'.
Write a program that prompts the user to enter their points for both tests and
the exam and converts the values to integers. The program should first check if
the points entered for the tests and exam are valid. If any of the test scores
are not between 0 and 25, or the exam score is not between 0 and 50, the
program should display an error message. Otherwise, the program should display
the total points and the grade.'''
def get_test_score():
    while True:
        score = int(input('Enter test score: '))
        if score not in range(1,26):
            print('Enter score 1-25')
        else:
            break
    return score

def get_exam_score():
    while True:
        score = int(input('Enter exam score: '))
        if score not in range (1,51):
            print('Enter score 1-50')
        else:
            break
    return score

def pass_or_fail(test1,test2,exam):
    if exam < 25:
        return False
    elif test1+test2+exam < 50:
        return False
    else:
        return True

def get_grade(test1,test2,exam):
    total = test1+test2+exam
    if total > 80:
        return 'Distinction'
    elif total > 60:
        return 'Credit'
    elif total > 50:
        return 'Pass'

def main():
    print('Test 1:')
    test1 = get_test_score()
    print('Test 2:')
    test2 = get_test_score()
    exam = get_exam_score()
    if pass_or_fail(test1,test2,exam) == True:
        print('Grade: {}'.format(get_grade(test1,test2,exam)),end='')
    else:
        print('Grade: Fail')
    input()

main()
