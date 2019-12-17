/*:
 ## App Exercise - Progress Updates
 
 >These exercises reinforce Swift concepts in the context of a fitness tracking app.
 
 In many cases you want to provide input to a function. For example, the progress function you wrote in the Functioning App exercise might be located in an area of your project that doesn't have access to the value of `steps` and `goal`. In that case, whenever you called the function, you would need to provide it with the number of steps that have been taken and the goal for the day so it can print the correct progress statement.
 
 Rewrite the function `progressUpdate`, only this time give it two parameters of type `Int` called `steps` and `goal`, respectively. Like before, it should print "You're off to a good start." if steps is less than 10% of goal, "You're almost halfway there!" if steps is less than half of goal, "You're over halfway there!" if steps is less than 90% of goal, "You're almost there!" if steps is less than goal, and "You beat your goal!" otherwise. Call the function and observe the printout.
 
 Call the function a number of times, passing in different values of `steps` and `goal`. Observe the printouts and make sure what is printed to the console is what you would expect for the parameters passsed in.
 */
func progressUpdate(steps: Int, goal: Int) {
    switch steps {
    case 0...1000:
        print("you're at a whopping 10 %")
    case 1001...4999:
        print("you are getting to the 25% of your goal")
    case 5000:
        print("you're half way")
    case 5001...9000:
        print("you're heading to your 90% of the daily goal")
    case 9001...10_000:
        print("you headding the your daily goal")
    default:
        print("Congrats- you are over your goal")
    }
}

progressUpdate(steps: 999, goal: 10_000)
progressUpdate(steps: 2500, goal: 10_000)
progressUpdate(steps: 10_010, goal: 10_000)
/*:
 Your fitness tracking app is going to help runners stay on pace to reach their goals. Write a function called pacing that takes four `Double` parameters called `currentDistance`, `totalDistance`, `currentTime`, and `goalTime`. Your function should calculate whether or not the user is on pace to hit or beat `goalTime`. If yes, print "Keep it up!", otherwise print "You've got to push it just a bit harder!"
 */
func pacing(currentDistance: Double, totalDistance: Double, currentTime: Double, goalTime: Double) {
    let result = currentTime / currentDistance
    let goal = goalTime / totalDistance
    
    if result < goal {
        print("you are on track")
    } else {
        print("you are a litte slow at the mo")
    }
}

pacing(currentDistance: 3.5, totalDistance: 5, currentTime: 21, goalTime: 40)
//: [Previous](@previous)  |  page 4 of 6  |  [Next: Exercise - Return Values](@next)
