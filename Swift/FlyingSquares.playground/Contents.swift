import UIKit
import PlaygroundSupport

let liveViewFrame = CGRect(x: 0, y: 0, width: 500, height: 500)
let liveView = UIView(frame: liveViewFrame)
liveView.backgroundColor = .white

PlaygroundPage.current.liveView = liveView

let smallFrame = CGRect(x: 0, y: 0, width: 100, height: 100)
let largeFrame = CGRect(x: 150, y: 150, width: 250, height: 250)

//double the hight and width of the view
let scaleTransform = CGAffineTransform(scaleX: 2.0, y: 2.0)

//rotate the view 180 degrees
let rotateTransform = CGAffineTransform(rotationAngle: .pi)

//move the view 200 point to the right and 200 poionts down
let translateTransform = CGAffineTransform(translationX: 200, y: 200)


let square = UIView(frame: smallFrame)
square.backgroundColor = .white

liveView.addSubview(square)

UIView.animate(withDuration: 2.0, animations: {
    square.backgroundColor = .orange
    
    // combines the transformations
    let comboTransform =
        scaleTransform.concatenating(rotateTransform).concatenating(translateTransform)
    
    square.transform = comboTransform
}) { (_) in
    UIView.animate(withDuration : 2.0, animations: {
        square.transform = CGAffineTransform.identity
    })
     
 }
/*
UIView.animate(withDuration: 3.0, animations: {
    square.backgroundColor = .orange
    square.frame = largeFrame
}) { (_) in
    UIView.animate(withDuration: 3.0) {
    square.backgroundColor = .purple
    square.frame = smallFrame
    }
}
 

UIView.animate(withDuration: 3.0, delay: 2.0, options: [.repeat], animations: {
    square.backgroundColor = . orange
    square.frame = CGRect(x: 400, y: 400, width: 100, height: 100)
} , completion: nil)
*/


