//
//  ContactDetailViewController.swift
//  ContactsFinal
//
//  Created by dave noonz on 2020-12-15.
//

import UIKit
import CoreData

class ContactDetailViewController: UIViewController {
    
    var contact: NSManagedObject? = nil
    var isDeleted: Bool = false
    var indexPath: IndexPath? = nil
    

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        nameLabel.text = contact?.value(forKey: "name") as? String
        phoneLabel.text = contact?.value(forKey: "phoneNumber") as? String
    }

    @IBOutlet weak var nameLabel: UILabel!
    @IBOutlet weak var phoneLabel: UILabel!
    @IBAction func deleteContact(_ sender: Any) {
        isDeleted = true
        performSegue(withIdentifier: "unwindToContactList", sender: self)
    }
    
    //Mark: - Navigation
    //edit contact information
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        if segue.identifier == "editContact" {
            guard let viewController = segue.destination as? AddContactViewController else {return}
            viewController.titleText = "Edit Contact"
            viewController.contact = contact
            viewController.indexPathForContact = self.indexPath!
        }
    }
}
