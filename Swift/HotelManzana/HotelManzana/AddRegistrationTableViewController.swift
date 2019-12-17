//
//  AddRegistrationTableViewController.swift
//  HotelManzana
//
//  Created by Eben Burger on 2019/09/26.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class AddRegistrationTableViewController: UITableViewController, SelectRoomTypeTableViewControllerDelegate {

    //section one
    @IBOutlet var firstNameTextField: UITextField!
    @IBOutlet var lastNameTextField: UITextField!
    @IBOutlet var emailAddressTextField: UITextField!
    
    //section two
    @IBOutlet var checkInDateLable: UILabel!
    @IBOutlet var checkInDatePicker: UIDatePicker!
    @IBOutlet var checkOutDateLable: UILabel!
    @IBOutlet var checkOutDatePicker: UIDatePicker!
    
    //section three
    @IBOutlet var numberOfAdultsLabel: UILabel!
    @IBOutlet var numberOfAdultsStepper: UIStepper!
    @IBOutlet var numberOfChildrenLabel: UILabel!
    @IBOutlet var numberOfChildrenStepper: UIStepper!
    
    //section four
    @IBOutlet var wifiSwitch: UISwitch!
    
    //section five
    @IBOutlet var roomTypeLabel: UILabel!
    
    //this holds the selected room type
    var roomType: RoomType?
    
    
    //indexed the rows & sections to allow the date Pickers to be hidden untill the user selects the Check-in ? check-out lable row
    let checkInDatePickerCellIndexPath = IndexPath(row: 1, section: 1)
    let checkOutDatePickerCellIndexPath = IndexPath(row: 3, section: 1)
    
    //indexed the row & section to allow to access the user selection on the label- once the user selects the label the Date Picker will open.
    let checkInDateLabelCellIndexPath = IndexPath(row: 0, section: 1)
    let checkOutDateLabelCellIndexPath = IndexPath(row: 2, section: 1)
    
    //this part hides the check-in date picker
    var isCheckInDatePickerShown: Bool = false {
        didSet {
            checkInDatePicker.isHidden = !isCheckInDatePickerShown
        }
    }
    
    //this part hides the check-out date picker
    var isCheckOutDatePickerShown: Bool = false {
        didSet {
            checkOutDatePicker.isHidden = !isCheckOutDatePickerShown
        }
    }
    
    //this is to conform to the SelectRoomTypeTableViewControllerDelegate protocol below.
    func didSelect(roomType: RoomType) {
        self.roomType = roomType
        updateRoomType()
    }
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        navigationItem.title = "New Guest Registration"
        
        //set the Date Pickers minimumdate
        let midnightToday = Calendar.current.startOfDay(for: Date())
        checkInDatePicker.minimumDate = midnightToday
        checkInDatePicker.date = midnightToday
        
        updateDateViews()
        updateNumberOfGuests()
        updateRoomType()
        // Uncomment the following line to preserve selection between presentations
        // self.clearsSelectionOnViewWillAppear = false

        // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
        // self.navigationItem.rightBarButtonItem = self.editButtonItem
    }
    
    func updateDateViews() {
        
        //this is the minimum date set to 24hours after the check-in date
        checkOutDatePicker.minimumDate = checkInDatePicker.date.addingTimeInterval(86400)
        
        //instance of the DateFormatter
        let dateFormatter = DateFormatter()
        dateFormatter.dateStyle = .medium // this is set to Nov 23, 2019
        
        //sets the lables to the dates form the date Pickers
        checkInDateLable.text = dateFormatter.string(from: checkInDatePicker.date)
        checkOutDateLable.text = dateFormatter.string(from: checkOutDatePicker.date)
    }
    /*
     This was impleminted to do testing only
     remember to do this-
     
    @IBAction func doneBarButtonTapped(_ sender: UIBarButtonItem) {
        let firstname = firstNameTextField.text!
        let lastName = lastNameTextField.text!
        let emailAddress = emailAddressTextField.text!
        
        let checkInDate = checkInDatePicker.date
        let checkOutDate = checkOutDatePicker.date
        
        let numberOfAdults = Int(numberOfAdultsStepper.value)
        let numberOfChildren = Int(numberOfChildrenStepper.value)
        
        let hasWifi = wifiSwitch.isOn
        
        //if the room type is not set then the "Not Set" will be shown
        let roomChoice = roomType?.name ?? "Not Set"
        
        print("Done Button Tapped")
        print("First Name: \(firstname)")
        print("Last Name: \(lastName)")
        print("Email Address: \(emailAddress)")
        print("Check In: \(checkInDate)")
        print("Check Out: \(checkOutDate)")
        print("Number of Adults \(numberOfAdults)")
        print("Number of Children \(numberOfChildren)")
        print("wifi \(hasWifi)")
        print("Room Type: \(roomChoice)")
        
    }*/
    
    //the action to update the date picker
    @IBAction func datePickerValueChanged(_ sender: UIDatePicker) {
        updateDateViews()
    }
    
    //sets row hights or hides them
    override func tableView(_ tableView: UITableView, heightForRowAt indexPath: IndexPath) -> CGFloat {
        switch indexPath {
        case checkInDatePickerCellIndexPath:
            if isCheckInDatePickerShown {
                return 216.0
            } else {
                return 0.0
            }
        case checkOutDatePickerCellIndexPath:
            if isCheckOutDatePickerShown {
                return 216.0
            } else {
                return 0.0
            }
        default:
            return 44.0
        }
    }
    
    //once the row is selected this code runs
    override func tableView(_ tableView: UITableView, didSelectRowAt indexPath: IndexPath) {
        tableView.deselectRow(at: indexPath, animated: true)
        
        //this is for the check-in date picker to hide or unhide
        switch indexPath {
        case checkInDateLabelCellIndexPath:
            
            if isCheckInDatePickerShown {
                isCheckInDatePickerShown = false
            } else if isCheckOutDatePickerShown {
                isCheckOutDatePickerShown = false
                isCheckInDatePickerShown = true
            } else {
                isCheckInDatePickerShown = true
            }
            
            //this updates the table on selection
            tableView.beginUpdates()
            tableView.endUpdates()
            
            //this is for the check-out date picker to hide or unhide
            case checkOutDateLabelCellIndexPath:
                    if isCheckOutDatePickerShown {
                        isCheckOutDatePickerShown = false
                    } else if isCheckInDatePickerShown {
                        isCheckInDatePickerShown = false
                        isCheckOutDatePickerShown = true
                    } else {
                        isCheckOutDatePickerShown = true
                }
                
                //this updates the table on selection
                tableView.beginUpdates()
                tableView.endUpdates()
                
                //final case-  the switch statement is now exhusted.
                default:
                break
            }
        }
    
    //this updates the label to match the stepper for each row (adults & children)- this function is then added to the stepper value changed action below, due to the table being static, this method is also added to the View Did Load
    func updateNumberOfGuests() {
        numberOfAdultsLabel.text = "\(Int(numberOfAdultsStepper.value))"
        numberOfChildrenLabel.text = "\(Int(numberOfChildrenStepper.value))"
    }
    
    //this is the Action to control the stepper
    @IBAction func stepperValueChanged(_ sender: UIStepper) {
        updateNumberOfGuests()
    }
    
    //this is the action for the wifi switch
    @IBAction func wifiSwitchChanged(_ sender: UISwitch) {
    }
    
    
    //function updates the room type label
    func updateRoomType() {
        if let roomType = roomType {
            roomTypeLabel.text = roomType.name
        } else {
            roomTypeLabel.text = "Not Set"
        }
    }
    
    
    @IBAction func cancelButtonTapped(_ sender: Any) {
        dismiss(animated: true, completion: nil)
    }
    
    //this is the segue to the SelectRoomTypeTableViewController
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        if segue.identifier == "SelectRoomType" {
            let destinationViewCOntroller = segue.destination as? SelectRoomTypeTableViewController
            destinationViewCOntroller?.delegate = self
            destinationViewCOntroller?.roomType = roomType
        }
    }
    
    //computered property. this creates a New Model Object Instance
    // this is also refranced into the RegistrationTableView Controller
    var registration: Registration? {
        
        guard let roomType = roomType else { return nil }
        
        let firstName = firstNameTextField.text ?? ""
        let lastName = lastNameTextField.text ?? ""
        let email = emailAddressTextField.text ?? ""
        let checkInDate = checkInDatePicker.date
        let checkOutDate = checkInDatePicker.date
        let numberOfAdults = Int(numberOfAdultsStepper.value)
        let numberOfChildren = Int(numberOfChildrenStepper.value)
        let hasWifi = wifiSwitch.isOn
        
        return Registration(firstName: firstName, lastName: lastName, emailAddress: email, checkInDate: checkInDate, checkOutDate: checkOutDate, numberOfAdults: numberOfAdults, numberOfChildren: numberOfChildren, roomType: roomType, wifi: hasWifi)
    }
    
    
}
