'''noonz
Driver's License Exam
The local driver's license office has asked you to create an application that
grades the written portion of the driver's liscense exam. The exam has 20
multiple-choice questions. Here are the correct answers:
1) A    6) B    11) A    16) C
2) C    7) C    12) D    17) B
3) A    8) A    13) C    18) B
4) A    9) C    14) A    19) D
5) D   10) B    15) D    20) A
Your program shoul store these correct answers in a list. The program should
read the student's answers for each of the 20 questions from a text file and
store the answers in another list. (Create your own text file to test the
application.) After the student's answers have been read from the file, the
program should display a message indicating whether the student passed or
failed the exam. (A student must correctly answer 15 of the 20 questions to
pass the exam.) It should then display the total number of correctly answered
questions, the total number of incorrectly answered questions, and a list
showing the question numbers of the incorrectly answered questions.'''
answers = ['A','C','A','A','D','B','C','A','C','B',
           'A','D','C','A','D','C','B','B','D','A']

def get_student_ans():
    student_ans = []
    with open('driver_exam.txt','r') as f:
        for i in f:
            student_ans.append(i.strip('\n'))
    return student_ans

def get_score(student_ans,answers):
    score = 0
    for i in range(len(student_ans)):
        if student_ans[i] == answers[i]:
            score += 1
    return score

def get_pass_or_fail(score):
    if score >= 15:
        return 'Pass'
    else:
        return 'Fail'

def get_correct_ans(student_ans,answers):
    correct_answers = []
    for i in range(len(answers)):
        if student_ans[i] in answers[i]:
            correct_answers.append(i+1)
    return correct_answers

def get_incorrect_ans(student_ans,answers):
    incorrect_answers = []
    for i in range(len(answers)):
        if student_ans[i] not in answers[i]:
            incorrect_answers.append(i+1)
    return incorrect_answers

def main():
    student_ans = get_student_ans()
    score = get_score(student_ans,answers)
    pass_or_fail = get_pass_or_fail(score)
    correct_ans = get_correct_ans(student_ans,answers)
    incorrect_ans = get_incorrect_ans(student_ans,answers)
    print('Driver\'s License Exam Results')
    print('Exam result: {}'.format(pass_or_fail))
    print('Total correct answers: {}/{}'
          .format(score,len(student_ans)))
    print('Total incorrect answers: {}/{}'
          .format(len(student_ans)-score,len(student_ans)))
    print('Question numbers that were incorrect: ',end='')
    
    '''for i in range(len(incorrect_ans)):
        if i+1 == len(incorrect_ans):
            print(incorrect_ans[i],end='')
        else:
            print(incorrect_ans[i],end=',')'''
    
    print(','.join(map(str,incorrect_ans)))
    print(','.join(str(i) for i in incorrect_ans))
    
    input()
            
main()
