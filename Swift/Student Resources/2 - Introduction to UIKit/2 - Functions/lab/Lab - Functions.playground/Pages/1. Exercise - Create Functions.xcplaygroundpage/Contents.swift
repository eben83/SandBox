/*:
 ## Exercise - Create Functions
 
 Write a function called `introduceMyself` that prints a brief introduction of yourself. Call the function and observe the printout.
 */
func introduceMyself() {
    print("I'm learning how to code")
}

introduceMyself()
/*:
 Write a function called `magicEightBall` that generates a random number and then uses either a switch statement or if-else-if statements to print different responses based on the random number generated. `let randomNum = Int.random(in: 0...4)` will generate a random number from 0 to 4, after which you can print different phrases corresponding to the number generated. Call the function multiple times and observe the different printouts.
 */
let randomNum = Int.random(in: 0...4)

func magicEightBall() {
    switch randomNum {
    case 1:
        print("you got a number one")
    case 2:
        print("you got a number 2")
    case 3:
        print("you got a 3")
    case 4:
        print("you got a 4")
    default:
        print("oops")
    }
}
magicEightBall()
//: page 1 of 6  |  [Next: App Exercise - A Functioning App](@next)
