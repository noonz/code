// define classes
class Person {
    let name: String

    init(name: String) {
        self.name = name
    }

    func sayHello() {
        print("Hello, there!")
    }
}

// defining a base class
class Vehicle {
    var currentSpeed = 0.0

    var description: String {
        "Traveling at \(currentSpeed) miles per hours"
    }

    func makeNoise() {
        // do nothing
    }
}

/* Create a subclass (syntax)
 class SomeSubClass: SomeSuperclass {
     // subclass definition goes here
 }
 */
class Bicycle: Vehicle {
    var hasBasket = false
}

// subclasses can also be subclasses, and provide inheritence down

// Override Methods and properties
class Train: Vehicle {
    // override vehicle makeNoise method
    override func makeNoise() {
        print("Choo Choo!")
    }
}

let train = Train()
train.makeNoise()

class Car: Vehicle {
    var gear = 1
    override var description: String {
        super.description + " in gear \(gear)"
    }
}

let car = Car()
car.currentSpeed = 25.0
car.gear = 3
print("Car: \(car.description)")

// override initializer
class Student: Person {
    var favoriteSubject: String

    init(name: String, favoriteSubject: String) {
        self.favoriteSubject = favoriteSubject
        super.init(name: name)
    }
}
