//
//  InformationFile.swift
//  ToDoList
//
//  Created by Eben Burger on 2019/10/03.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

/*
 this is the information for the To Do List
 
 To define the model-
    this is the file ToDo.swift
    this toDo list structure is held there. this also defines the information required for the ToDo list
 
 configuring the Table View Controller-
    this is the ToDoTableViewController.swift
    created the empty array that will hold the ToDo List objects (this is from the ToDo.swift: Structure)
        var todos = [ToDo]()- this is the structure
 
 NumberOfRowsInSection
    how many rows in the section will the list contain-
        this is where you can count the number of rows that will be displayed,
        once the array has been made- array has a function .count
            this can simply be used like: return todos.count
 
 
 cellForRowAt
    this is called everytime a cell is about to be displayed on screen
    this method also provides the IndexPath
        you'll use IndexPath to determine which cell you're dealing with
        ignoring Custom cells for now
            Standard Implementation-
                Dequeue a cell for the given index path
                get the model out the arraythat corrisponds to the cell being displayed
                update the cell's properties appropriatly, & return the cell from the method
 since the app has no data to disply-
    adding in a static function to act as the data to test the app before adding in the 'codable' property - (codable- is to save the user data)
 
 
 Supplying Initial Data-
    since there is no user data, creating sample data will assist with this matter untill the user enters their data.
    creating a static function in the ToDo's Structure to retrive the data stored on disk, then for the 1st while just return 'nil' as there is no data yet... then in the same structure loading in the samaple data again in a static function, using the Structure layout so that somethign will appear on screen, this could be used for testing and or for sample data for the user to view.
            
            static func loadSampleToDo() -> [ToDo] {
            let todo1 = ToDo(title: "ToDo One", isComplete: fasle, dueDate: Date(), notes: "Note 1")
            etc...
            }
    once the static sample data is loaded-
        add in the logic in the viewDidLoad()-
            override func viewDidLoad() {
                .....
                if let savedToDos = ToDo.loadToDos() {
                    todos = savedtoDos                      This loads the saved data from the Structure
                } else {
                    todos = ToDo.loadSampleToDos()          This loads the smaple data from the Structure
                }
            }
 
    set the prototype cell to the identifier allocated in the ToDoTableViewCOntroller.swift, "ToDoCellIdentifier", this is don in the Atrobutes setting on the cell.
 
 Add and delete data-
 
    adding a bar button item, to the top right and changing the 
 
 */
