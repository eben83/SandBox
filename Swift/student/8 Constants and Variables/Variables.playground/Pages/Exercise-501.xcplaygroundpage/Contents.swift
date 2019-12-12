/*:
 ## Exercise: 501
 
 You may know the popular darts game called 501. Players start with a score of 501, and have to work down to zero. Here are the rules:
 
 - Each player plays a “round” where they throw three darts at a board.
 - Each throw can score between 1 and 20 points, which may be doubled or tripled depending where it hits on the board.
 - It is also possible to score 25 for the outer bulls-eye or 50 for the inner bulls-eye.
 
 House rule: At the end of three rounds, whoever is closest to zero without going below zero is the winner.
 
 - callout(Exercise): Imagine you’re a game shark. You want to fool people into thinking you’re terrible at this game, but then come back and beat them in one swoop at the end. Model your game progress using variables.\
 \
 Start with a variable set to `501` to hold your overall score.\
 Create another variable set to `0` to hold the score for each round.\
 For each throw, update the value of the round score by adding points from the throw.\
 At the end of each round, calculate your current overall score by subtracting the round score from it. Assign the new value to your overall score, and re-set the round score to zero.\
 \
 How slowly can you “improve” your performance without arousing suspicion? \
 \
 After each round, `print` some statements that your opponents might make. If you can, use the value of your current score in their statements.
 */
var playerOne = 501
var scorePlayerOne = 0
var roundPlayerOne = 0

var playerTwo = 501
var scorePlayerTwo = 0
var roundPlayerTwo = 0

let newLine = "\n"

func lineSpace(){
    newLine
    newLine
}

func playerOneRoundOne(){
    roundPlayerOne += 1
    scorePlayerOne += 2
    scorePlayerOne += 17
    scorePlayerOne += 20
    playerOne -= scorePlayerOne
    
    print("This is Round \(roundPlayerOne)")
    print("Player One Score: \(scorePlayerOne)")
    print("Player One Remaining: \(playerOne)")
    lineSpace()
    
}

func playerTwoRoundOne(){
    roundPlayerTwo += 1
    scorePlayerTwo += 2
    scorePlayerTwo += 17
    scorePlayerTwo += 20
    playerTwo -= scorePlayerTwo
    
    print("This is Round \(roundPlayerTwo)")
    print("Player One Score: \(scorePlayerTwo)")
    print("Player One Remaining: \(playerTwo)")
    lineSpace()
}

playerOneRoundOne()
playerTwoRoundOne()

func playerOneRoundTwo(){
    roundPlayerOne += 1
    scorePlayerOne += 3
    scorePlayerOne += 10
    scorePlayerOne += 50
    playerOne -= scorePlayerOne
    
    print("This is Round \(roundPlayerOne)")
    print("Player One Score: \(scorePlayerOne)")
    print("Player One Remaining: \(playerOne)")
    lineSpace()
}

func playerTwoRoundTwo(){
    scorePlayerTwo -= scorePlayerTwo
    roundPlayerTwo += 1
    scorePlayerTwo += 3
    scorePlayerTwo += 10
    scorePlayerTwo += 50
    playerTwo -= scorePlayerTwo
    
    print("This is Round \(roundPlayerTwo)")
    print("Player One Score: \(scorePlayerTwo)")
    print("Player One Remaining: \(playerTwo)")
    lineSpace()
}
playerOneRoundTwo()
playerTwoRoundTwo()

func playerOneRoundThree(){
    roundPlayerOne += 1
    scorePlayerOne += 3
    scorePlayerOne += 10
    scorePlayerOne += 50
    playerOne -= scorePlayerOne
    
    print("This is Round \(roundPlayerOne)")
    print("Player One Score: \(scorePlayerOne)")
    print("Player One Remaining: \(playerOne)")
    lineSpace()
}

func playerTwoRoundThree(){
    scorePlayerTwo -= scorePlayerTwo
    roundPlayerTwo += 1
    scorePlayerTwo += 3
    scorePlayerTwo += 10
    scorePlayerTwo += 50
    playerTwo -= scorePlayerTwo
    
    print("This is Round \(roundPlayerTwo)")
    print("Player One Score: \(scorePlayerTwo)")
    print("Player One Remaining: \(playerTwo)")
    lineSpace()
}
playerOneRoundTwo()
playerTwoRoundTwo()

/*:
 
 _Copyright © 2017 Apple Inc._
 
 _Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_
 
 _The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._
 
 _THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._
 */
//: [Previous](@previous)  |  page 13 of 13
