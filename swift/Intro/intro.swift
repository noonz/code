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

// Functions

func greet(person: String) {
    print("Hello \(person)")
}

greet(person: "Dave")
