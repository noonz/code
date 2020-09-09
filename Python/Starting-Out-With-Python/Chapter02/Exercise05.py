'''noonz
Distance Traveled
Assuming there are no accidents or delays, the distance that a car travels down
the interstate can be calculated with the following formula:
Distance = Speed X Time
A car is travelling at 70 miles per hour. Write a program that displays:
-The distance the car will travel in 6 hrs
-The distance the car will travel in 10 hours
-The distance the car will travel in 15 hours'''

def get_distance(speed,time):
    return speed * time

def main():
    print('A car driving 70m/hr will travel:')
    print(get_distance(70,6),'miles in 6 hours')
    print(get_distance(70,10),'miles in 10 hours')
    print(get_distance(70,15),'miles in 15 hours',end='')
    input()

main()
