'''Noonz
Sales Prediction
A Company has determined that its annual profit is typically 23 percent of
total sales. Write a program that asks the user to enter the projected amount
of total sales, then displays the profit that will be made from that amount'''

def get_sales():
    sales = float(input('Enter yearly sales: $'))
    return sales

def calc_profit(sales):
    return sales * 0.23

def main():
    sales = get_sales()
    profit = calc_profit(sales)
    print('Your 23% profit on ${:.2f} is ${:.2f}.'.format(sales,profit),end='')
    input()

main()
    
