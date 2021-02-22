//
//  AddContactViewController.swift
//  ContactsFinal
//
//  Created by dave noonz on 2020-12-15.
//

import UIKit
import CoreData

class AddContactViewController: UIViewController {
    var titleText = "Add Contact"
    var contact: NSManagedObject? = nil
    var indexPathForContact: IndexPath? = nil

    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
        titleLabel.text = titleText
        if let contact = self.contact {
            nameTextField.text = contact.value(forKey: "name") as? String
            phoneNumberTextField.text = contact.value(forKey: "phoneNumber") as? String
        }
    }
    @IBOutlet weak var nameTextField: UITextField!
    @IBOutlet weak var phoneNumberTextField: UITextField!
    @IBOutlet weak var titleLabel: UILabel!
    
    /*
    // MARK: - Navigation

    // In a storyboard-based application, you will often want to do a little preparation before navigation
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        // Get the new view controller using segue.destination.
        // Pass the selected object to the new view controller.
    }
    */
    //save contact details
    @IBAction func saveAndClose(_ sender: Any) {
        performSegue(withIdentifier: "unwindToContactList", sender: self)
    }
    //add contact close button
    @IBAction func close(_ sender: Any) {
        nameTextField.text = nil
        phoneNumberTextField.text = nil
        performSegue(withIdentifier: "unwindToContactList", sender: self)
    }
    
}
