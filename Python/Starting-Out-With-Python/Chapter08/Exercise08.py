'''noonz
Sentence Capitilizer
Write a program with a function that accepts a string as an argument and returns
a copy of the string with the first character of each sentence capitalized. For
instance, if the argument is 'hello. my name is Joe. what is your name?' the
function should return the string 'Hello. My name is Joe. What is your name?'
The program should let the user enter a string and then pass it to the function.
The modified string should be displayed.'''
end_punct = ['.','?','!']

def get_string():
    string = input('Type some lowercase sentences: ')
    return string

def get_sentences(string):
    sentences = []
    current_sent = ''
    for ch in string:
        current_sent += ch
        if ch in end_punct:
            sentences.append(current_sent.lstrip(' '))
            current_sent = ''
    return sentences

def case_sentence(sentences):
    new_sentence = ''
    for line in sentences:
        if line[0].islower():
            new_sentence += line[0].upper()
        new_sentence += line[1:]
        
    # search for punctuation in current sentence by slicing the line length   
        for ch in new_sentence[-len(line):]:
            if ch in end_punct:
                new_sentence += ' '
                
    return new_sentence

def main():
    string = get_string()
    sentences = get_sentences(string)
    new_sentence = case_sentence(sentences)
    print(new_sentence)
    input()

main()