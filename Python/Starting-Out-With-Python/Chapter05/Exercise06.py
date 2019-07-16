'''noonz
Calories from Fat and Carbohydrates
A nutritionist who works for a fitness club helps members by evaluating their
diets. As part of her evaluation, she asks members for the number of fat grams
and carbohydrate grams that they consumed in a day. Then, she calculates the
number of calories that result from the fat, using the following formula:
Calories from fat = fat grams * 9
Next, she calculates the number of calories that result from the carbs, using
the following formula:
Calories from carbs = carb grams * 4
The nutritionist asks you to write a program that will make these calcs.'''
def get_fat():
    fat = int(input('Enter grams in fat: '))
    return fat

def get_carbs():
    carbs = int(input('Enter grams in carbs: '))
    return carbs

def convert_fat_to_cal(fat):
    return fat * 9

def convert_carbs_to_cal(carbs):
    return carbs * 4

def main():
    print('Calorie Converter')
    print('-----------------')
    fat = get_fat()
    carbs = get_carbs()
    fat_cals = convert_fat_to_cal(fat)
    carb_cals = convert_carbs_to_cal(carbs)
    print('\nFat: {}g\nCals: {}\n\nCarbs: {}g\nCals: {}'
          .format(fat,fat_cals,carbs,carb_cals),end='')
    input()

main()
