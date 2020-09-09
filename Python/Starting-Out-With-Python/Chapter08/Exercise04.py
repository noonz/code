'''noonz
Morse Code Converter
Morse code is a code where each letter of the English alphabet, each digit, and
various punctuation characters are represented by a series of dots and dashes.
Table 8-4 shows part of the code.
Write a program that asks the user to enter a string, then converts that string
to Morse Code.'''
morse_code = {
    ' ': ' ',',':'--.--','.':'.-.-.-','?':'..--..','0':'-----','1':'.----',
    '2':'..---','3':'...--','4':'....-','5':'.....','6':'-....','7':'--...',
    '8':'---..','9':'----.','A':'.-','B':'-...','C':'-.-.','D':'-..','E':'.',
    'F':'..-.','G':'--.','H':'....','I':'..','J':'.---','K':'-.-','L':'.-..',
    'M':'--','N':'-.','O':'---','P':'.--.','Q':'--.-','R':'.-.','S':'...',
    'T':'-','U':'..-','V':'...-','W':'.--','X':'-..-','Y':'-.-','Z':'--..'
}
def get_string():
    user_string = input('Enter string to convert to morse code: ')
    return user_string

def convert_string(string):
    new_string = ''
    for ch in string:
        new_string += morse_code[ch.upper()] + ' '
    new_string = new_string.rstrip(' ')
    return new_string

def main():
    user_string = get_string()
    new_string = convert_string(user_string)
    print('Morse code:\n{}'.format(new_string))
    input()

main()