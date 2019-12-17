/*:
 ## Exercise - Create Closures
 
 Create a closure assigned to a constant `blankClosure` that has no parameters and no return value.
 */
let blankClosure = { () -> Void in
    print("This closure has not perameters and no return value")
}

blankClosure()
/*:
  Create a closure assigned to a constant `fourClosure` that has no parameters and returns an `Int`. The body of the closure should always return the value 4. Call the closure four times.
 */
let fourClosure = { () -> Int in
    let number = 4
    return number
}

print(fourClosure())
/*:
 Create a closure assigned to a constant `greeting` that accepts a `name` string argument with no return value. Within the body of the closure, print the argument. Call the closure four times using "Gary", "Jane", "Rick", and "Beth" as arguments.
 */
let name = ["Gary", "Jane", "Rick", "Beth"]

let greeting = {(name: [String]) -> Void in
    print(name)
}
greeting(name)
//: page 1 of 3  |  [Next: Exercise - Passing Closures as Arguments and Syntactic Sugar](@next)
