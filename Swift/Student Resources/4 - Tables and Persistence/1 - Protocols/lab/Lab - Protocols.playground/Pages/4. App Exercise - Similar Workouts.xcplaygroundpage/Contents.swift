/*:
 ## App Exercise - Similar Workouts
 
 >These exercises reinforce Swift concepts in the context of a fitness tracking app.
 
 Previously in app exercises, you've used inheritance to enforce similar behavior between different kinds of workouts. However, you can enforce this behavior between different workouts using protocols.
 
 Create a protocol `Workout` with two requirements: a settable property called `distance` and a settable property called `time`, both of type `Double`.
 */
protocol Workout {
    var distance: Double { get }
    var time: Double { get }
    
    func simpleWorkoutDescription(workout: Workout)
}

/*:
 Create two structs, `RunningWorkout` and `SwimmingWorkout`. Both should conform to the `Workout` protocol. Uncomment the function `simpleWorkoutDescription` below, create an instance of each of your structs, and call `simpleWorkoutDescription` twice, passing in a `RunningWorkout` object and then a `SwimmingWorkout` object.
 */
struct runningWorkout: Workout {
    var distance: Double
    var time: Double
    
    var runningWorkouts: String {
        return "you ran \(distance) with a time of \(time)"
    }
    func simpleWorkoutDescription(workout: Workout) {
        print("You went \(workout.distance) meters in \(workout.time) seconds.")
    }
}
struct swimmingWorkout: Workout {
    var distance: Double
    var time: Double
    
    var swimmingWorkouts: String {
        return "you swam \(distance) with a time of \(time)"
    }
    func simpleWorkoutDescription(workout: Workout) {
        print("You went \(workout.distance) meters in \(workout.time) seconds.")
    }
}

let swim1 = swimmingWorkout(distance: 1200, time: 3456)
let run1 = runningWorkout(distance: 5000, time: 1500)



print(swim1.swimmingWorkouts)
print(run1.runningWorkouts)


//: [Previous](@previous)  |  page 4 of 5  |  [Next: App Exercise - Heart Rate Delegate](@next)
