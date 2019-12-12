//
//  ToDo.swift
//  ToDoList
//
//  Created by Eben Burger on 2019/10/03.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import Foundation


struct ToDo: Codable {
    var title: String
    var isComplete: Bool
    var dueDate: Date
    var notes: String? //optional
    
    static func loadToDos() -> [ToDo]? {
        guard let codedToDos = try? Data(contentsOf: ArchiveURL)
            else { return nil }
        let propertyListDecoder = PropertyListDecoder()
        return try? propertyListDecoder.decode(Array<ToDo>.self, from: codedToDos)
    }
    
    static func saveToDos(_ todos: [ToDo]) {
        let propertyListEncoder = PropertyListEncoder()
        let codedToDos = try? propertyListEncoder.encode(todos)
        try? codedToDos?.write(to: ArchiveURL, options: .noFileProtection)
    }
    

    
    static func loadSampleToDos() -> [ToDo] {
        let todo1 = ToDo(title: "ToDo One", isComplete: false, dueDate: Date(), notes: "Note 1")
        let todo2 = ToDo(title: "ToDo Two", isComplete: false, dueDate: Date(), notes: "Note 2")
        let todo3 = ToDo(title: "ToDo Three", isComplete: false, dueDate: Date(), notes: "Note 3")
        
        return [todo1, todo2, todo3]
    }
    
    /*
     this lets you create a date formatter only once and it is not allocated to any specific part of the app-
     you are able to add this to the app for the setup and let it be for the intire life of the app.
     */
    static let dueDateFormatter: DateFormatter = {
        let formater = DateFormatter()
        formater.dateStyle = .short
        formater.timeStyle = .short
        return formater
    }()
    
    static let DocumentsDirectory =
        FileManager.default.urls(for: .documentDirectory, in: .userDomainMask).first!
    static let ArchiveURL =
        DocumentsDirectory.appendingPathComponent("todos").appendingPathExtension("plist")
    
}
