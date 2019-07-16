'''noonz
Areas of Rectangles
The area of a rectangle is the rectangle's length times its width. Write a
program that asks for the length and width of two rectangles. The program
should tell the user which rectangle has the greater area, or if the areas
are the same.'''
def get_area(length,width):
    return length * width

def get_rectangle():
    length = int(input('Enter length: '))
    width = int(input('Enter width: '))
    return get_area(length,width)

def check_rectangles(rect1,rect2):
    if rect1 > rect2:
        return 'Rectangle 1 has a larger area'
    elif rect2 > rect1:
        return 'Rectangle 2 has a larger area'
    else:
        return 'Both areas are the same'

def main():
    print('Rectangle 1:')
    rect1 = get_rectangle()
    print('\nRectangle 2:')
    rect2 = get_rectangle()
    print(check_rectangles(rect1,rect2))
    input()

main()
