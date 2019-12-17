import UIKit

let name = "Tracy"

switch name {
case "Eben":
    print("hello \(name)")
case "John":
    print("not my name")
default:
    print("O'NO")
}

var distance = 875

switch distance {
case 0...9:
    print("you almset done")
case 10...99:
    print("meduim distance to go")
case 100...999:
    print("damn, long way")
default:
    print("are you sure")
}

var largest: Int

let a = 12
let b = 32

if a > b {
    largest = a
} else {
    largest = b
}
largest
