import Foundation
import GameplayKit

let randomCohice = GKRandomDistribution(lowestValue: 0, highestValue: 2)

enum Sign: String {
    case rock, paper, scissors
    
    var emoji: String {
        switch self {
        case .rock: return "👊"
        case .paper: return "✋"
        case .scissors: return "✌️"
        }
    }
}

// this function assigns a random function for the computer.
func randomSign() -> Sign {
    let sign = randomCohice.nextInt()
    if sign == 0 {
        return .rock
    } else if sign == 1 {
        return .paper
    } else {
        return .scissors
    }
}

var computer = randomSign()

// game play function where you choose a sign and the computer generates a sign-
//
func gamePlay(_ playerOne: Sign, playerTwo: Sign) -> String {
    let winner = " You Win!!"
    let loser = "You lose, better luck next time"
    if playerOne == playerTwo {
        return "Draw"
    } else if playerOne == .rock, playerTwo == .scissors {
        return winner
    } else if playerOne == .rock, playerTwo == .paper {
        return loser
    } else if playerOne == .paper, playerTwo == .rock {
        return winner
    } else if playerOne == .paper, playerTwo == .scissors {
        return loser
    } else if playerOne == .scissors, playerTwo == .paper {
        return winner
    } else {
        return loser
    }
}


gamePlay(.paper, playerTwo: computer)
computer.emoji
computer


// using a switch statement to the game.
func whoIsTheWinner (_ playerOneNew: Sign, _ PlayerTwoNew: Sign) -> String {
    switch playerOneNew {
    case .rock:
        switch (PlayerTwoNew) {
        case .rock: return " Draw"
        case .paper: return "you lose"
        case .scissors: return "you win"
        }
        case .paper:
            switch (PlayerTwoNew) {
            case .rock: return " you win"
            case .paper: return "draw"
            case .scissors: return "you lose"
            }
            case .scissors:
                switch (PlayerTwoNew) {
                case .rock: return "you lose"
                case .paper: return "you win"
                case .scissors: return "draw"
                }
            }
        }

var game = whoIsTheWinner(.rock, computer)
computer
