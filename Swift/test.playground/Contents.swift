import UIKit

struct Car {
    let make: String
    var odo: Int
}

var carOne = Car(make: "Ford", odo: 0)
var carTwo = Car(make: "Opel", odo: 0)
carOne.odo
carTwo.odo

carOne.odo += 120
carTwo.odo += 40
carTwo.odo += 123

carOne.odo
carTwo.odo

var rev = carOne.odo > carTwo.odo || carOne.odo < carTwo.odo
if rev == false {
    print(" you are going to far")
} else {
    print("you are not driving enough")
}

struct Person {
    var name: String
    
    func sayHello() {
        print("good Day \(name)")
    }
}

let me = Person(name: "Eben")

me.sayHello()

struct Products {
    let productCode: String
    var unitPrice: Double
    
    func showProduct() {
        print("\(productCode) costs \(unitPrice)")
    }
}

var one = Products(productCode: "RPX130", unitPrice: 23.89)
var two = Products(productCode: "RPX131", unitPrice: 26.00)

one.showProduct()
one.unitPrice += 2.5
one.showProduct()


struct Temperature {
    var celsius: Double
    func processing() {
        print(celsius)
    }
}

let measureOne = Temperature(celsius: 30)

let fahrenheitValue: Double = 109
let celsiusValue: Double = (fahrenheitValue - 32) / 1.8

let measureTwo = Temperature(celsius: celsiusValue)

measureOne.processing()
measureTwo.processing()

struct TempTwo {
    var celsius: Double
    
    init(celsius: Double) {
        self.celsius = celsius
    }
    init(fahe: Double) {
        celsius = (fahe - 32) / 1.8 //this is the dot notation you are after
    }
}

let temoOne = TempTwo(celsius: 23)
let tempTwp = TempTwo(fahe: 123)

print(temoOne.celsius, tempTwp.celsius)

struct TempThree {
    var celsiusThree: Double
    
    var fahrThree: Double {
        return celsiusThree * 1.8 + 32
    }
    var kelvin: Double {
        return celsiusThree + 273.15
    }
}

let currentTemp = TempThree(celsiusThree: 0)
print(currentTemp.fahrThree, currentTemp.kelvin)

struct TempFour {
    static var boiling = 100
}

let boining = TempFour.boiling
boining * 2 // just took the property of the TempFour and multiplied by 2

struct Speed {
    var kms: Double

    
    init(kms: Double) {
        self.kms = kms
    }
    init(miles: Double) {
        kms = miles / 1.61
    }
}

let newSpeed = Speed(kms: 13)
let newMiles = Speed(miles: 50)

print(newSpeed)
print(newMiles)

let array1 = [1,2,3]
let array2 = [4,5,6]

let array3 = [array1, array2]

let firstArray = array3[1]
print(firstArray)


for index in 1...12 {
    print("This is number \(index)")
}

var numberOfLives = 3
var stillAlive = true

while stillAlive {
    numberOfLives -= 1
    print("you still alive with \(numberOfLives) left")
    if numberOfLives == 0 {
        stillAlive = false
    }
}


// Protocols
class Shoe: CustomStringConvertible {
    let color: String
    let size: Int
    let hasLaces: Bool
    
    init (color: String, size: Int, hasLaces: Bool) {
        self.color = color
        self.size = size
        self.hasLaces = hasLaces
    }
    
    var description: String {
        let doesOrDoesNot = hasLaces ? "does" : "does not"
        return "Shoe(color: \(color), Size: \(size), and \(doesOrDoesNot) have laces)"
    }
}

let myShoe = Shoe(color: "Black", size: 6, hasLaces: true)
let yourShoe = Shoe(color: "White", size: 7, hasLaces: false)

print(myShoe)
print(yourShoe)
