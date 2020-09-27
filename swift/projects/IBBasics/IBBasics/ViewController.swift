//
//  ViewController.swift
//  IBBasics
//
//  Created by dave noonz on 2020-09-24.
//

import UIKit

class ViewController: UIViewController {
    @IBOutlet var myButton: UIButton!

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        myButton.setTitleColor(.red, for: .normal)
    }
    
    @IBAction func buttonPressed(_ sender: Any) {
        print("The button was pressed")
    }

}

