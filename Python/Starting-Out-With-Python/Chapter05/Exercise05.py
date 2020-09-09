'''noonz
Property Tax
A county collects property taxes on the assessment value of property, which is
60 percent of the property's actual value. For example, if an acre of land is
valued at $10,000, its assessment value is $6,000. The property tax is then .72c
for each $100 of the assessment value. The tax for the acre assessed at $6,000
will be $43.20. Write a program that asks for the actual value of a piece of
property and displays the assessment value and property tax.'''
def get_value():
    value = float(input('Enter property value: $'))
    return value

def get_assessment(value):
    return value * .6

def get_tax(assessment):
    return assessment // 100 * .72

def main():
    value = get_value()
    assessment = get_assessment(value)
    tax = get_tax(assessment)
    print('Value: ${:,.2f}\nAssessment: ${:,.2f}\nTax: ${:,.2f}'
          .format(value,assessment,tax),end='')
    input()

main()
