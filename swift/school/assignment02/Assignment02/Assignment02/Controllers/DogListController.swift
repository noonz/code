//
//  DogListController.swift
//  Assignment02
//
//  Created by dave noonz on 2021-02-23.
//

import UIKit

class DogListController: UITableViewController {
    
    // Variables
    var dogList = [Dog]()
    var results: [String] = []
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Uncomment the following line to preserve selection between presentations
        // self.clearsSelectionOnViewWillAppear = false

        // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
        // self.navigationItem.rightBarButtonItem = self.editButtonItem
        CustomizeScreen()
        fetchDogos()
    }
    
    func fetchDogos() {
        DogService.shared.fetchDogs { (dog) in
            
            // append breeds to results array by iterating through dictionary values from 'dict'
            DispatchQueue.main.async {
                self.dogList = dog
                let dict = self.dogList[0].message
                for (breed, subBreedList) in dict {
                    if subBreedList.isEmpty{
                        self.results.append(breed.capitalized)
                    } else {
                        for subBreed in subBreedList {
                            self.results.append("\(subBreed.capitalized) \(breed.capitalized)")
                        }
                    }
                }
                self.tableView.reloadData()
            }
        }
    }
    
    func CustomizeScreen() {
        // nav bar
        self.navigationController?.navigationBar.barTintColor = UIColor.systemBlue
        
        
        // tab bar
        self.tabBarController?.tabBar.barTintColor = UIColor.systemBlue
        self.tabBarController?.tabBar.tintColor = .black
        self.tabBarController?.tabBar.unselectedItemTintColor = .white
        
        // background
        self.view.backgroundColor = .systemTeal
    }

    // MARK: - Table view data source

    override func numberOfSections(in tableView: UITableView) -> Int {
        // #warning Incomplete implementation, return the number of sections
        return 1
    }

    override func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        // #warning Incomplete implementation, return the number of rows
        return results.count
    }

    // TODO: populate cells
    override func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        let cell = tableView.dequeueReusableCell(withIdentifier: "dogName", for: indexPath)

        // Configure the cell text and colour
        cell.textLabel?.text = results.sorted()[indexPath.row]
        cell.contentView.backgroundColor = .systemTeal
        return cell
    }
    

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
