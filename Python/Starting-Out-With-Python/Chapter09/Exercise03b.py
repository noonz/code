'''noonz
File Encryption and Decryption
Write a second program that opens an encrypted file and displays its decrypted
contents on the screen.'''

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

def decrypt_string():
    with open('Ch9_E3file.txt','r') as f:
        string = f.read()
    d_string = ''
    for ch in string:
        if ch in CODE.values():
            d_string += CODE[ch]
        elif ch.isspace():
            d_string += ch
    return d_string

def main():
    d_string = decrypt_string()
    print('The decrypted string is \'{}\''.format(d_string),end='')
    input()

main()
                
