/*:
 ## App Exercise - A Functioning App
 
 >These exercises reinforce Swift concepts in the context of a fitness tracking app.
 
 As you may have guessed, functions are key to making your app work. For example, in every exercise dealing with step count until now, you have simply assigned a number of steps to a `steps` variable. This isn't very realistic seeing as the number of steps you take increments one at a time and continues changing throughout the day.
 
 A reoccurring process like this is a perfect candidate for a function. Write a function called `incrementSteps` after the declaration of `steps` below that will increment `steps` by one and then print its value. Call the function multiple times and observe the printouts.
 */
var steps: Double = 12

func incrementSteps() {
    steps += 1
    print("you took one extra step, your steps are now at \(steps)")
}
incrementSteps()
incrementSteps()
incrementSteps()
incrementSteps()
incrementSteps()
incrementSteps()
incrementSteps()
incrementSteps()
incrementSteps()

/*:
 Similarly, if you want to regularly provide progress updates to your user, you can put your control flow statements that check on progress into a function. Write a function called `progressUpdate` after the declaration of `goal` below. The function should print "You're off to a good start." if `steps` is less than 10% of `goal`, "You're almost halfway there!" if `steps` is less than half of `goal`, "You're over halfway there!" if `steps` is less than 90% of `goal`, "You're almost there!" if `steps` is less than `goal`, and "You beat your goal!" otherwise. Call the function and observe the printout. Remember, you can convert numbers using the appropriate Int or Double initializer.
 */
let goal: Double = 10_000


func progressUpdate(stepping: Double) {
    if stepping > goal {                                    // everything else
        print("you beat your goal \(stepping)")
    } else if stepping >= (goal * 0.9) {               // 1000 steps
        let first = (goal * 0.9)
        print("you're off to a good start \(first) steps")
    } else if stepping >= (goal * 0.5) {       //2500 steps
        let second = (goal * 0.5)
        print("you're almost half way \(second) steps")
    } else if stepping >= (goal * 0.25) {         // 5000 steps
        let third = (goal * 0.25)
        print("your now half way with your goal \(third)")
    } else if stepping >= (goal * 0.1) {           // 9000 steps
        let forth = (goal * 0.1)
        print("your now on 90% of your goal \(forth)")
    } else {
        print("Get off your arse")
    }
}

progressUpdate(stepping: 10100)


//: [Previous](@previous)  |  page 2 of 6  |  [Next: Exercise - Parameters and Argument Labels](@next)
