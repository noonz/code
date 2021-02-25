//
//  ImageViewController.swift
//  Assignment02
//
//  Created by dave noonz on 2021-02-24.
//

import UIKit

class ImageViewController: UIViewController {

    // IBOUTLETS
    @IBOutlet weak var randomBtn: UIButton!
    @IBOutlet weak var dogImageView: UIImageView!
    @IBOutlet weak var testNav: UINavigationItem!
    
    
    // Variables
    var dogImage = [Image]()
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        CustomizeScreen()
        fetchImage()
    }
    
    @IBAction func randomImageBtn(_ sender: UIButton) {
        fetchImage()
    }
    
    // convert dog image into URL then set imageView
    func fetchImage() {
        DogService.shared.fetchImage { (image) in
            DispatchQueue.main.async {
                self.dogImage = image
                let url = URL(string: self.dogImage[0].message)
                let data = try? Data(contentsOf: url!)
                self.dogImageView.image = UIImage(data: data!)
            }
        }
    }
    
    // function to customize screen
    func CustomizeScreen() {
        // nav bar
        self.navigationController?.navigationBar.barTintColor = UIColor.systemBlue
        
        
        // tab bar
        self.tabBarController?.tabBar.barTintColor = UIColor.systemBlue
        self.tabBarController?.tabBar.tintColor = .black
        self.tabBarController?.tabBar.unselectedItemTintColor = .white
        
        // view
        self.view.backgroundColor = .systemTeal
        
        // button
        randomBtn.layer.cornerRadius = 35
        randomBtn.backgroundColor = UIColor.systemBlue
        randomBtn.setTitleColor(.black, for: .normal)
        
    }

    /*
    // MARK: - Navigation

    // In a storyboard-based application, you will often want to do a little preparation before navigation
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        // Get the new view controller using segue.destination.
        // Pass the selected object to the new view controller.
    }
    */

}
