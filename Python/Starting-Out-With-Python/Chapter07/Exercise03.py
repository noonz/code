'''noonz
Rainfall Statistics
Design a program that lets the user enter the total rainfall for each of 12
months into a list. The program should calculate and display the total rainfall
for the year, the average monthly rainfall, the months with the highest and
lowest amounts.'''
def get_rainfall():
    rainfall = []
    for i in range(3):
        print('Enter rainfall for month {}: '.format(i+1),end='')
        current_rainfall = int(input())
        rainfall.append(current_rainfall)
    return rainfall

def main():
    rainfall = get_rainfall()
    print('\nTotal rainfall: {}'.format(sum(rainfall)))
    print('Average rainfall: {:.0f}'.format(sum(rainfall)/len(rainfall)))
    print('Highest: {}'.format(max(rainfall)))
    print('Lowest: {}'.format(min(rainfall)),end='')
    input()

main()
