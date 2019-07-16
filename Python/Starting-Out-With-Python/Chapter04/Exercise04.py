'''noonz
Distance Travelled
The distance a vehicle travels can be calculated as follows:
distance = speed * time
For example, if a train travels 40 miles per hour for three hours, the distance
travelled is 120 miles. Write a program that asks the user for the speed of a
vehicle (in miles per hour) and the number of hours ir has travelled. It should
then use a loop to display the distance the vehicle has travelled for each hour
of tht time period. Here is an example of the desired output:
What is the speed of the vehicle in mph? 40 [Enter]
How many hours has it travelled? 3 [Enter]
Hour    Distance Travelled
---------------------------
1                40
2                80
3               120'''
def get_distance(speed,time):
    return speed*time

def get_speed():
    speed = int(input('What is the speed of the vehicle in mph?: '))
    return speed

def get_time():
    hours = int(input('How many hours has it travelled?: '))
    return hours

def main():
    speed = get_speed()
    time = get_time()
    print('Hours     Distance Travelled')
    print('----------------------------')
    for i in range(time):
        print(i+1,'              ',get_distance(speed,i+1))
    input()

main()
