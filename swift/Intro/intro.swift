//
//  main.swift
//  Intro
//
//  Created by dave noonz on 2020-09-17.
//

import Foundation

// Variables
var intNumber = Int()
var myName = "Dave"
var varA: Float
var myBool = true
var randNumbers = [Int]() // create an array of integers

// if, else if
var grade: Int = 90
var gradeLetter: Character
if grade >= 90 {
    gradeLetter = "A"
} else if grade >= 80 {
    gradeLetter = "B"
} else if grade >= 70 {
    gradeLetter = "C"
} else if grade >= 60 {
    gradeLetter = "D"
} else {
    gradeLetter = "F"
}

// Switch statement
switch gradeLetter {
case "A":
    print("You got an A!")
case "B":
    print("You got a B!")
case "C":
    print("You got a C.")
case "D":
    print("You got a D.")
case "F":
    print("You failed.")
default:
    print("Unknown grade")
}

// For-in loop
for _ in 1 ..< 3 {
    print("For-in loop")
}

for _ in 0 ..< 10 {
    randNumbers.append(Int.random(in: 1 ... 500))
}

var max = 0
for num in randNumbers {
    if num > max {
        max = num
    }
}

// repeat while loop
var varC = 10
repeat {
    print("repeat while loop")
    varC += 1
} while varC < 12

print(max)

/* Functions
 func functionName (nameForType: Type, otherType: Type) -> ReturnType {
     //body of the function
 }
 */
// alternate argument labels
func sayHello(to person: String, and anotherPerson: String) {
    print("Hello \(person) and \(anotherPerson)")
}

// omit one argument label and return 2 types
func add(_ firstNumber: Int, to secondNumber: Int) -> Int {
    return firstNumber + secondNumber
}

// add default parameter values
func display(teamName: String, score: Int = 0) {
    print("\(teamName): \(score)")
}

func greet(person: String) {
    print("Hello \(person)")
}

/* Structures
 struct Name {
     var name: String
 }
 */

struct StepCounter {
    var totalSteps: Int = 0 {
        willSet {
            print("About to set totalSteps to \(newValue)")
        }
        didSet {
            if totalSteps > oldValue {
                print("Added \(totalSteps - oldValue) steps")
            }
        }
    }
}

var stepCounter = StepCounter()
stepCounter.totalSteps = 40
stepCounter.totalSteps = 100

// Type methods
struct Temperaure {
    static var boilingPoint = 100
}

let boilingPoint = Temperaure.boilingPoint
