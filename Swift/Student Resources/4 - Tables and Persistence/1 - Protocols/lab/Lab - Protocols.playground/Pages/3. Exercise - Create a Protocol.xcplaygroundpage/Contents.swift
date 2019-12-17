/*:
 ## Exercise - Create a Protocol
 
 Create a protocol called `Vehicle` with two requirements: a nonsettable `numberOfWheels` property of type `Int`, and a function called `drive()`.
 */
protocol Vehicle {
    var numberOfWheels: Int { get }
    
    func drive()
}

/*:
 Define a `Car` struct that implements the `Vehicle` protocol. `numberOfWheels` should return a value of 4, and `drive()` should print "Vroom, vroom!" Create an instance of `Car`, print its number of wheels, then call `drive()`.
 */
struct Car: Vehicle {
    let numberOfWheels: Int = 4
    
    
    var carVehicle: String {
        return "the car has \(numberOfWheels) wheels and sounds like Vroom Vroom"
    }
    
    func drive() {
        print(carVehicle)
    }
}

let car1 = Car()

print(car1.carVehicle)
/*:
 Define a `Bike` struct that implements the `Vehicle` protocol. `numberOfWheels` should return a value of 2, and `drive()` should print "Begin pedaling!". Create an instance of `Bike`, print its number of wheels, then call `drive()`.
 */

struct Bike: Vehicle {
    let numberOfWheels: Int = 2
    
    var bikeVehicle: String {
        return "the bike has \(numberOfWheels) wheels and you should Begin Pedaling"
    }
    func drive() {
        print(bikeVehicle)
    }
}

let bike1 = Bike()

print(bike1.bikeVehicle)


//: [Previous](@previous)  |  page 3 of 5  |  [Next: App Exercise - Similar Workouts](@next)
