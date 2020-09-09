'''noonz
File Encryption and Decryption
Write a program that uses a dictionary to assign 'codes' to each letter for the
alphabet. The program should open a specified text file, read its contents, then
use the dictionary to write an encrypted version of the file's contents to a
second file. Each character in the second file should contain the code for the
corresponding character in the first file. Write a second program that opens an
encrypted file and displays its decrypted contents on the screen.'''

CODE = {
'A':')','a':'0','B':'(','b':'9','C':'*','c':'8',
'D':'&','d':'7','E':'^','e':'6','F':'%','f':'5',
'G':'$','g':'4','H':'#','h':'3','I':'@','i':'2',
'J':'!','j':'1','K':'Z','k':'z','L':'Y','l':'y',
'M':'X','m':'x','N':'W','n':'w','O':'V','o':'v',
'P':'U','p':'u','Q':'T','q':'t','R':'S','r':'s',
'S':'R','s':'r','T':'Q','t':'q','U':'P','u':'p',
'V':'O','v':'o','W':'N','w':'n','X':'M','x':'m',
'Y':'L','y':'l','Z':'K','z':'k','!':'J','1':'j',
'@':'I','2':'i','#':'H','3':'h','$':'G','4':'g',
'%':'F','5':'f','^':'E','6':'e','&':'D','7':'d',
'*':'C','8':'c','(':'B','9':'b',')':'A','0':'a',
':':',',',':':','?':'.','.':'?','<':'>','>':'<',
"'":'"','"':"'",'+':'-','-':'+','=':';',';':'=',
'{':'[','[':'{','}':']',']':'}'
    }

def get_string():
    string = input('Enter something to encrypt: ')
    return string

def encrypt_string(string):
    e_string = ''
    
    for ch in string:
        if ch in CODE.keys():
            e_string += CODE[ch]
        elif ch.isspace():
            e_string += ch
    return e_string

def main():
    string = get_string()
    encrypted_string = encrypt_string(string)
    print('Your encrypted string is \'{}\''.format(encrypted_string))
    with open('Ch9_E3file.txt','w') as f:
        f.write(encrypted_string)

main()
