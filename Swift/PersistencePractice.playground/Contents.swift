import UIKit

struct Note: Codable {
    let title: String
    let text: String
    let timeStamp: Date
}


//new instance of the NOTE structure, added an Array for the notes.
let newNote = Note(title: "Grocery run", text: "Pick upi moyo, mustard, tomato, and pickles", timeStamp: Date())
let note1 = Note(title: "Note one", text: "simple Note", timeStamp: Date())
let note2 = Note(title: "Note 2", text: "simple note", timeStamp: Date())
let note3 = Note(title: "Note three", text: "this is another note", timeStamp: Date())
let note4 = Note(title: "note four", text: "this is yet another note", timeStamp: Date())
var notes: [Note] = [newNote, note1, note2, note3, note4]

//this is where the file will be saved
    let documentsDirectory =
        FileManager.default.urls(for: .documentDirectory, in: .userDomainMask).first!
    let archiveURL = documentsDirectory.appendingPathComponent("notes_test").appendingPathExtension("plist")

//encodes the note ready for saving
let propertyListEncoder = PropertyListEncoder()
let encodedNote = try? propertyListEncoder.encode(notes)

//saves the data
try? encodedNote?.write(to: archiveURL, options: .noFileProtection)

// this retreves the data
let propertyListDecoder = PropertyListDecoder()

if let retrievedNoteData = try? Data(contentsOf: archiveURL),
    let decodedNote = try? propertyListDecoder.decode(Array<Note>.self, from: retrievedNoteData) {
    print(decodedNote)
}
