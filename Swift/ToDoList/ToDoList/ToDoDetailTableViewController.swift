//
//  ToDoDetailTableViewController.swift
//  ToDoList
//
//  Created by Eben Burger on 2019/10/22.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ToDoDetailTableViewController: UITableViewController {
    
    @IBOutlet var titleTextField: UITextField!
    @IBOutlet var isCompleteButton: UIButton!
    
    @IBOutlet var dueDateLable: UILabel!
    @IBOutlet var dueDatePickerView: UIDatePicker!
    @IBOutlet var notesTextView: UITextView!
    @IBOutlet var saveButton: UIBarButtonItem!
    
    var isPickerHidden = true
    let datelabelIndexPath = IndexPath(row: 0, section: 1)
    let datePickerIndexPath = IndexPath(row: 1, section: 1)
    let notesTextViewIndexPath = IndexPath(row: 0, section: 2)
    
    let normalCellHight:CGFloat = 44 // setting the cell height of the date picker
    let largeCellHeight: CGFloat = 200
    
    var todo: ToDo?
    

    override func viewDidLoad() {
        super.viewDidLoad()
        
        /*
         this function pulls the data from the list to the edit/ add static view controller
         */
        if let todo = todo {
            navigationItem.title = "To-Do"
            titleTextField.text = todo.title
            isCompleteButton.isSelected = todo.isComplete
            dueDatePickerView.date = todo.dueDate
            notesTextView.text = todo.notes
        } else {
            dueDatePickerView.date = Date().addingTimeInterval(24*60*60)
        }
        
        updateDueDateLable(date: dueDatePickerView.date)
        updateSaveButtonState()
        
        /*
        dueDatePickerView.date = Date().addingTimeInterval(24*60*60) // adds 24hrs to the date picker
        updateDueDateLable(date: dueDatePickerView.date) //call the func to update the lable to match the date picker
        
        */
        // Uncomment the following line to preserve selection between presentations
        // self.clearsSelectionOnViewWillAppear = false

        // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
        // self.navigationItem.rightBarButtonItem = self.editButtonItem
    }
    
    func updateSaveButtonState() {
        let text = titleTextField.text ?? ""
        saveButton.isEnabled = !text.isEmpty
    }

    /*
     This function updates the save button state each time there is a tap on the keyboard, so
     it keeps the save button sate true- enabled when there is a title and disabled when there is not
     */
    @IBAction func textEditingChanged(_ sender: UITextField) {
        updateSaveButtonState()
    }
    /*
     this function fires once the return key is pressed, the details of the app are hidden by the keyboard- so once the return key is pressed the keyboard is hidden.
     */
    @IBAction func returnPressed(_ sender: UITextField) {
        titleTextField.resignFirstResponder()
    }
    /*
     this function also known as a helper method, switches between the selected and unselected state of the button, the images have been loaded to the assets librery- then set the states there- under state Config
     */
    @IBAction func isCompleteButtonTapped(_ sender: UIButton) {
        isCompleteButton.isSelected = !isCompleteButton.isSelected
    }
    
    func updateDueDateLable(date: Date) {
        dueDateLable.text = ToDo.dueDateFormatter.string(from: date)
    }
    
    
    @IBAction func datePickerChanged(_ sender: UIDatePicker) {
        updateDueDateLable(date: dueDatePickerView.date)
    }
    
    override func tableView(_ tableView: UITableView, heightForRowAt indexPath: IndexPath) -> CGFloat {
        switch indexPath {
        case datePickerIndexPath:
            return isPickerHidden ? 0:
                dueDatePickerView.frame.height
        case notesTextViewIndexPath:
            return largeCellHeight
        default:
            return normalCellHight
        }
    }
    
    override func tableView(_ tableView: UITableView, didSelectRowAt indexPath: IndexPath) {
        if indexPath == datelabelIndexPath {
            isPickerHidden = !isPickerHidden
            dueDateLable.textColor = isPickerHidden ? .black :
            tableView.tintColor
            tableView.beginUpdates()
            tableView.endUpdates()
            
        }
    }
    
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        super.prepare(for: segue, sender: sender)
        
        guard segue.identifier == "saveUnwind" else { return }
        
        let title = titleTextField.text!
        let isComplete = isCompleteButton.isSelected
        let dueDate = dueDatePickerView.date
        let notes = notesTextView.text
        
        todo = ToDo(title: title, isComplete: isComplete, dueDate: dueDate, notes: notes)
    }
    
    // MARK: - Table view data source

    /*
    override func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        let cell = tableView.dequeueReusableCell(withIdentifier: "reuseIdentifier", for: indexPath)

        // Configure the cell...

        return cell
    }
    */

    /*
    // Override to support conditional editing of the table view.
    override func tableView(_ tableView: UITableView, canEditRowAt indexPath: IndexPath) -> Bool {
        // Return false if you do not want the specified item to be editable.
        return true
    }
    */

    /*
    // Override to support editing the table view.
    override func tableView(_ tableView: UITableView, commit editingStyle: UITableViewCell.EditingStyle, forRowAt indexPath: IndexPath) {
        if editingStyle == .delete {
            // Delete the row from the data source
            tableView.deleteRows(at: [indexPath], with: .fade)
        } else if editingStyle == .insert {
            // Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view
        }    
    }
    */

    /*
    // Override to support rearranging the table view.
    override func tableView(_ tableView: UITableView, moveRowAt fromIndexPath: IndexPath, to: IndexPath) {

    }
    */

    /*
    // Override to support conditional rearranging of the table view.
    override func tableView(_ tableView: UITableView, canMoveRowAt indexPath: IndexPath) -> Bool {
        // Return false if you do not want the item to be re-orderable.
        return true
    }
    */

    /*
    // MARK: - Navigation

    // In a storyboard-based application, you will often want to do a little preparation before navigation
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        // Get the new view controller using segue.destination.
        // Pass the selected object to the new view controller.
    }
    */
    
    
    
}
