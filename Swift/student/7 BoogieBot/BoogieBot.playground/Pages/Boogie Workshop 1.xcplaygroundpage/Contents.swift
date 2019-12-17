/*:
 ## Boogie Workshop
 
 This page is here for you to create your own routines. 
 
 Remember the moves:
 
 - `leftArmUp()`, `leftArmDown()`, `rightArmUp()`, `rightArmDown()`
 - `leftLegUp()`, `leftLegDown()`, `rightLegUp()`, `rightLegDown()`
 - `shakeItLeft()`, `shakeItRight()`, `shakeItCenter()`
 - `jumpUp()`, `jumpDown()`
 - `fabulize()`, `defabulize()`
 
 To sign your work:
 
 `setBotTitle("My Awesome Dance")`\
 `setBotSubtitle("By The Boogiemaster")`
*/
startBot()
startRecording()
setBotTitle("My Dancing Craze")
setBotSubtitle("By Eben")
func leftSide(){
    fabulize()
    leftArmUp()
    leftLegUp()
    leftLegDown()
    leftArmDown()
}
func rightSide(){
    fabulize()
    rightArmUp()
    rightLegUp()
    rightArmDown()
    rightLegDown()
}
func jump(){
    leftArmUp()
    rightArmUp()
    jumpSequance()
    
}
func jumpSequance(){
    leftArmUp(); rightArmUp()
    jumpUp()
    jumpDown()
    jumpUp()
    jumpDown()
}

leftSide()
rightSide()
leftSide()
rightSide()
jumpSequance()
defabulize()





//: Continue with your creativity.
//:
//:[Previous](@previous)  |  page 10 of 13  |  [Next: Boogie Workshop](@next)
