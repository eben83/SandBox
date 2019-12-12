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
setBotTitle("Crazy")
setBotSubtitle("By Eben")

func shackIt(){
    shakeItLeft(); shakeItRight(); shakeItCenter()
    fabulize()
}
func leftLeg(){
    leftLegUp()
    leftLegDown()
}
func danceOne(){
    shackIt()
    leftArmUp()
    leftArmDown()
    leftLeg()
    shackIt()
    defabulize()
}

danceOne()







//: Continue with your creativity.
//:
//:[Previous](@previous)  |  page 11 of 13  |  [Next: Boogie Workshop](@next)
