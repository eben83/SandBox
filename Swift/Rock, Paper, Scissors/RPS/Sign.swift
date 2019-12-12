//
//  sign.swift
//  RPS
//
//  Created by Eben Burger on 2019/07/01.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

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
func gamePlay(_ playerOne: Sign, _ playerTwo: Sign) -> String {
    switch playerOne {
    case .rock:
        switch (playerTwo) {
        case .rock: return " Draw"
        case .paper: return "you lose"
        case .scissors: return "you win"
        }
    case .paper:
        switch (playerTwo) {
        case .rock: return " you win"
        case .paper: return "draw"
        case .scissors: return "you lose"
        }
    case .scissors:
        switch (playerTwo) {
        case .rock: return "you lose"
        case .paper: return "you win"
        case .scissors: return "draw"
        }
    }
}

var rockGame = gamePlay(.rock, computer)

