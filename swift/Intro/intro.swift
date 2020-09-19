//
//  main.swift
//  Intro
//
//  Created by dave noonz on 2020-09-17.
//

import Foundation

// Variables
var intNumber = Int()
var randNumbers = [Int]() // create an array of integers

// if, else if

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

print(max)

// Switch statement
var temp = 0
switch temp {
case ...(-30):
    print("Super cold")
case -29 ... 0:
    print("Cold")
case 0...:
    print("Warm")
default:
    print("Temp unknown")
}

// Functions

func greet(person: String) {
    print("Hello \(person)")
}

greet(person: "Dave")
