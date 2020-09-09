'''noonz
Miles to Kilometers Table
Write a program that displays a table of distances in miles and their equivalent
distances in kilometers, rounded to 2 decimal places. One mile is equivalent to
1.60934 kilometers. The table should be generated using a loop, and should
include values in 10 mile increments from 10 to 80.'''
def miles_to_km(miles):
    return miles * 1.60934

def main():
    miles = 0
    print('Miles    Kilometers')
    print('-------------------')
    while miles != 80:
        miles += 10
        print('{}        {:.2f}'.format(miles,miles_to_km(miles)))
    input()
    
main()
        
