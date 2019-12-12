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
setBotTitle("Jumping")
setBotSubtitle("All day")

func jumping(){
    fabulize()
    jumpUp()
    jumpDown()
    jumpUp()
    jumpDown()
}
func crazyJumping(){
    fabulize()
    leftArmUp(); rightArmUp()
    jumping()
    rightArmDown()
    leftArmDown()
}
func runningMan(){
    leftLegUp()
    leftLegDown()
    rightLegUp()
    rightLegDown()
}

fabulize()
crazyJumping()
runningMan()
runningMan()
crazyJumping()
runningMan()
runningMan()
defabulize()




//: Continue with your creativity.
//:
//:[Previous](@previous)  |  page 12 of 13  |  [Next: Boogie Workshop](@next)
