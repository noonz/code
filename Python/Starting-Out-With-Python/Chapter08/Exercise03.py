'''noonz
Date Printer
Write a program that reads a string from the user containing a date in the form
mm/dd/yyy. It should print the date in the format March 12, 2018.'''
months = {
    '01':'January','02':'February','03':'March','04':'April','05':'May',
    '06':'June','07':'July','08':'August','09':'September','10':'October',
    '11':'November','12':'December'
}

def get_date():
    date = input('Enter date in format \'mm/dd/yyyy\': ')
    return date

def split_date(date):
    return date.split('/')

def print_date(date_list):
    print('{} {}, {}'.format(months[date_list[0]],date_list[1],date_list[2]))

def main():
    date = get_date()
    date_list = split_date(date)
    print_date(date_list)
    input()

main()