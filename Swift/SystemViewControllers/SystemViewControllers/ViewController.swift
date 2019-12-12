//
//  ViewController.swift
//  SystemViewControllers
//
//  Created by Eben Burger on 2019/09/18.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit
import SafariServices
import MessageUI

class ViewController: UIViewController , UIImagePickerControllerDelegate, UINavigationControllerDelegate, MFMailComposeViewControllerDelegate {

    @IBOutlet var imageView: UIImageView!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }
    
    
    // action for the Share button
    @IBAction func shareButtonTapped(_ sender: UIButton) {
        guard let image = imageView.image else { return }
        let activityController = UIActivityViewController(activityItems: [image], applicationActivities: nil)
        activityController.popoverPresentationController?.sourceView = sender
        
        present(activityController, animated: true, completion: nil)
    }
    
    //action for the safari button
    @IBAction func safariButtonTapped(_ sender: UIButton) {
        
        //1st create the url from a string which is an optional so needs to be unwrapped
        if let url = URL(string: "http://www.apple.com") {
            
            //next create an instance of SFSafariViewController with the url created above
            let safariViewController = SFSafariViewController(url: url)
            
            // last present the Safari view controller to the user
            present(safariViewController, animated: true, completion: nil)
        }
    }
    
    //action for the camera button
    @IBAction func photoButtonTapped(_ sender: UIButton) {
        
        
        
        /*
         instance of the UI Image Controller
         this will transfer the selected image's information back into
         the app- this also sets the delegate
        */
        //create an insatance
        let imagePicker = UIImagePickerController()
        //sets the delegate
        imagePicker.delegate = self
        
        /*
         creating the alert- the action Sheet prefeered Style, make a pop up from the
         bottom of the page to give the user a
         choice
        */
        let alertController = UIAlertController(title: "Choose Image Source", message: nil, preferredStyle: .actionSheet)
        
        //this is the Cancel button at the bottom of the action style popup
        let cancelAction = UIAlertAction(title: "Cancel", style: .cancel, handler: nil)
        
        //this checks that the camera is available
        if UIImagePickerController.isSourceTypeAvailable(.camera) {
            
            //this is the 1st button in the action style popup- camera choice
            let cameraAction = UIAlertAction(title: "Camera", style: .default , handler: {action in imagePicker.sourceType = .camera
                self.present(imagePicker, animated: true, completion: nil)
                /*
                 remember to add the access to ask user as this is regarded as privacy-
                 you must add the "Privacy- Camera Usage Description" in the document outline
                 then in the info.plist file
                 this will ask the user to either accept or decline the access to the photo librery
                 the Value can be: to share photos from the camera
                 */
            })
            alertController.addAction(cameraAction)
        }
        
        if UIImagePickerController.isSourceTypeAvailable(.photoLibrary) {
            
            //this is the 2nd button in the action style popup
            let photoLibraryAction = UIAlertAction(title: "Photo Library", style: .default, handler: { action in imagePicker.sourceType = .photoLibrary
                self.present(imagePicker, animated: true, completion: nil)
                /*
                 remember to add the access to ask user as this is regarded as privacy-
                 you must add the "Privacy- Photo Librery Usage Description" in the document outline
                 then in the info.plist file
                 this will ask the user to either accept or decline the access to the photo librery
                 the Value can be: to share photos from the Photo Librery
                */
            })
            alertController.addAction(photoLibraryAction)
        }
        alertController.addAction(cancelAction)
        alertController.popoverPresentationController?.sourceView = sender
        
        //present the alert
        present(alertController, animated: true,completion: nil)
    }
    
    //this method tells the deligate that the user has selected an image- then adds it to the ImageView
    func imagePickerController(_ picker: UIImagePickerController, didFinishPickingMediaWithInfo info: [UIImagePickerController.InfoKey : Any]) {
        guard let selectedImage = info[.originalImage] as? UIImage else { return }
        
        imageView.image = selectedImage
        dismiss(animated: true, completion: nil)
    }
    
    //action for the email button
    @IBAction func emailButtonTapped(_ sender: UIButton) {
        
        //canSendMail() checks if the device has available mail services- if not will print a message
        if !MFMailComposeViewController.canSendMail() {
            print("Can not send mail")
            return
        }
        // the MFMailComposeViewControllerDelegate is responsable for dismissing the mail compose view controler at the appropriate time
        
        //create an instance
        let mailComposer = MFMailComposeViewController()
        //set the delegate
        mailComposer.mailComposeDelegate = self
        
        //sets the needed information for sending an eamil
        mailComposer.setToRecipients(["example@example.com"])
        mailComposer.setSubject("Look at this")
        mailComposer.setMessageBody("Hello this is an email from the app I made", isHTML: false)
        
        present(mailComposer, animated: true, completion: nil)
    }
    
    /*
     you are bale to use the delegate method to dismiss the compose view
    */
    func mailComposeController(_ controller: MFMailComposeViewController, didFinishWith result: MFMailComposeResult, error: Error?) {
        dismiss(animated: true, completion: nil)
    }
}

