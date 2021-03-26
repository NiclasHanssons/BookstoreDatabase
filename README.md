# Bookstore Database
![image](https://user-images.githubusercontent.com/58398343/112664012-c3043b00-8e59-11eb-8e3b-50fe3a22381b.png)
### Description

The bookstore database manager application can be used to track the available inventory of a business, as well as it's store supply. In the application, the user can add, edit or remove inventory items, authors and publishers, as well as manage a store's supply, like adding new books to the supply, edit or delete them, as well as edit the supply's stock of a given item.

##### Setting up the project:
* Start Visual Studio and press 'Clone a reoisitory' on the start page.
* Enter the URL for the project's GitHub page, select where to store it locally and press 'Clone'.

##### Setting up the Databse:
* Start SQL Server Management Studio (SSMS) and connect to localhost.
* In 'Object Explorer', expand the 'localhost' server and right-click on 'Databases' and choose 'Restore Database...'.
* In the 'General' tab, select 'Device:' as the source for the restoration, then click the 'three small dots' button on the very right.
* Select 'File' as the 'Backup media type' and press 'Add'.
* Navigate to the 'NiclasHanssonTheBookshelf.bak' file, select it and press 'OK' (If you can not access the Visual Studio project directory, try placing the database file in a directory SSMS has access to, like the root of your disk)
* Once back in the 'Select backup devices' page, press 'OK', followed by 'OK' on the next page.

##### Running the program:
* Now that everything has been set up, you are now ready to use the program as intended!
