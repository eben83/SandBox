import UIKit

struct Person {
    let firstName: String
    let lastName: String
    
    func sayHello() {
        print("Hello mu name is \(firstName) \(lastName) and a number")
    }
}

let personA = Person(firstName: "Eben", lastName: "Burger")
let PersonB = Person(firstName: "Tracy", lastName: "Burger")

personA.sayHello()
PersonB.sayHello()


let one: Int
let two: Int
let three: Int

one = 1
two = 2

three = one + two



personA.sayHello()
PersonB.sayHello()
