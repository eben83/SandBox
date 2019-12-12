
import UIKit

class FurnitureDetailViewController: UIViewController, UIImagePickerControllerDelegate, UINavigationControllerDelegate {
    
    var furniture: Furniture?
    
    @IBOutlet var imageView: UIImageView!
    @IBOutlet var choosePhotoButton: UIButton!
    @IBOutlet var furnitureTitleLabel: UILabel!
    @IBOutlet var furnitureDescriptionLabel: UILabel!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        updateView()
    }
    
    func updateView() {
        guard let furniture = furniture else {return}
        if let imageData = furniture.imageData,
            let image = UIImage(data: imageData) {
            choosePhotoButton.setTitle("", for: .normal)
            choosePhotoButton.setImage(image, for: .normal)
        } else {
            choosePhotoButton.setTitle("Choose Image", for: .normal)
            choosePhotoButton.setImage(nil, for: .normal)
        }
        
        furnitureTitleLabel.text = furniture.name
        furnitureDescriptionLabel.text = furniture.description
    }
    
    @IBAction func choosePhotoButtonTapped(_ sender: UIButton) {
        
        //instance of the UI Image Picker Controller
        let imagePicker = UIImagePickerController()
        
        //setting the picker's delegate to self
        imagePicker.delegate = self
        
        //creating the Alert Controller
        let alertController = UIAlertController(title: "Choose your Image Source", message: nil, preferredStyle: .actionSheet)
        
        // creating the cancel alert action
        let cancelAction = UIAlertAction(title: "Cancel", style: .cancel, handler: nil)
        
        //check if the camera source is available
        if UIImagePickerController.isSourceTypeAvailable(.camera) {
            
            //creates the camera alert actin
            let cameraAction = UIAlertAction(title: "Camera", style: .default, handler: { (_) in imagePicker.sourceType = .camera
                self.present(imagePicker, animated: true, completion: nil)
            })
            //adds the action
            alertController.addAction(cameraAction)
        }
        
        // checks the photo librery source is avalible
        if UIImagePickerController.isSourceTypeAvailable(.photoLibrary) {
            
            //creates the photo librery action alert
            let photoAction = UIAlertAction(title: "Photo Librery", style: .default, handler: { (_) in imagePicker.sourceType = .photoLibrary
                self.present(imagePicker, animated: true, completion: nil)
            })
            //ass the action
            alertController.addAction(photoAction)
        }
        
        // adds the cancel action
        alertController.addAction(cancelAction)
        
        //creates the popover screen for the action alert
        alertController.popoverPresentationController?.sourceView = sender
        
        
        //presents the action alert
        present(alertController, animated: true, completion: nil)
    }
    
    //this retrives the selected image from the user
    func imagePickerController(_ picker: UIImagePickerController, didFinishPickingMediaWithInfo info: [UIImagePickerController.InfoKey : Any]) {
        //this uses the .originalImage to retrive the image from the info directory, then unwraps the result and casts it as UIImage
        guard let selectedImage = info[.originalImage] as? UIImage else {
            return
        }
        imageView.image = selectedImage
        //this dismisses the the image selector and loads the image to the UIImageView
        dismiss(animated: true, completion: nil)
    }

    @IBAction func actionButtonTapped(_ sender: UIButton) {
        guard let image = imageView.image else { return }
        
        let activityController = UIActivityViewController(activityItems: [image], applicationActivities: nil)
        
        activityController.popoverPresentationController?.sourceView = sender
        
        present(activityController, animated: true, completion: nil)
    }
    
}
