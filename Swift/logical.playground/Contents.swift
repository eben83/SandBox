import UIKit

let score = 72
var grade: Character

switch score {
case 90...100:
    grade = "a"
    print("\(grade) and your score was \(score)")
case 80...89:
    grade = "b"
    print("\(grade) and your score was \(score)")
case 70...79:
    grade = "c"
    print("\(grade) and your score was \(score)")
default:
    grade = "f"
    print("\(grade) and your score was \(score)")
}
