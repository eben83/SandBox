//
//  Game.swift
//  ApplePie
//
//  Created by Eben Burger on 2019/07/23.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import Foundation

struct Game {
    
    var word: String
    var incorrectMovesRemaning: Int
    var guessedLetters: [Character]
    mutating func playerGuessed (letter: Character) {
        guessedLetters.append(letter)
        if !word.contains(letter) {
            incorrectMovesRemaning -= 1
        }
    }
    
    var formattedWord: String {
        var guessedWord = ""
        for letter in word {
            if guessedLetters.contains(letter) {
                guessedWord += "\(letter)"
            } else {
                guessedWord += "_"
            }
        }
        return guessedWord
    }
}
