/*:
 ## Exercise: Switch
 
 This enum represents targets that the player might hit in a game:
*/
enum Target {
    case red, green, blue, gold
}
//: This function returns a score given a particular target:
//let targetRed = Target.red
let targetGreen = Target.green
//let targetBlue = Target.blue
//let targetGold = Target.Gold

switch target {
case .red: 10
case .green: 15
case .blue: 25
case .gold: 50

}
//: - callout(Exercise): Update the `score(target:)` function to use a switch statement and return the correct score for each target. The statements below tell you the values to aim for:
targetRed    // This should be 10
t  // This should be 15
var targetBlue = Target.blue   // This should be 25
var target = Target.gold   // This should be 50


/*:
 
 _Copyright © 2017 Apple Inc._
 
 _Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_
 
 _The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._
 
 _THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._
 */
//: [Previous](@previous)  |  page 21 of 21
