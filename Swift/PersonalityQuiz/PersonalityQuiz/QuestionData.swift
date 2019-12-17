//
//  QuestionData.swift
//  PersonalityQuiz
//
//  Created by Eben Burger on 2019/08/19.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import Foundation

struct Question {
    var text: String
    var type: ResponceType
    var answers: [Answer]
    
}

enum ResponceType {
    case single, multiple, ranged
}

struct Answer {
    var text: String
    var type: AnimalType
}

enum AnimalType: Character {
    case dog = "🐶", cat = "🐱", rabbit = "🐰", turtle = "🐢"
    
    var definition: String {
        switch self {
        case .dog:
            return "you are incredibly outgoing. YOu surround yourself with the people you love and enjoy activities with your friends."
        case .cat:
            return "Mischievous, yet mild- tempered, you enjoy doing things on your own terms."
        case .rabbit:
            return "You love everything that's soft. You are healthy and full of energy."
        case .turtle:
            return "You are wise beyond your years, and you focus on the details. Slow and steady wins the race."
        }
    }
}
