'''noonz
Total Purchase
A customer in a store is purchasing three items. Write a program that asks for
the price of each item, then displays the subtotal of the sale, the amount
of sales tax, and the total. Assume the sales tax is 7%'''
def get_item_price():
    item1 = float(input('Item 1: $'))
    item2 = float(input('Item 2: $'))
    item3 = float(input('Item 3: $'))
    return item1,item2,item3

def calc_subtotal(item1,item2,item3):
    return item1+item2+item3

def calc_sales_tax(item1,item2,item3):
    return (item1+item2+item3) * .07

def calc_total(subtotal, sales_tax):
    return subtotal + sales_tax

def main():
    item1,item2,item3 = get_item_price()
    subtotal = calc_subtotal(item1,item2,item3)
    sales_tax = calc_sales_tax(item1,item2,item3)
    total = calc_total(subtotal,sales_tax)
    print('Subtotal: ${:.2f}'.format(subtotal))
    print('Sales Tax: ${:.2f}'.format(sales_tax))
    print('Total: ${:.2f}'.format(total),end='')
    input()

main()
    
