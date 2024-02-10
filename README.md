# Citizen Development🤓

An application written according to technical specifications during the recruitment process. 
Created to work with a local database, it includes basic functionality (adding/deleting/editing).


## Interface💻

The application presents a window with a bar on top. The bar has four tabs:

#### Insert
Allows you to add a new entry to the database. 
Includes three text fields(Application Name, User Name, Comment) and also "Insert" button.

#### Update
Allows you to update a record into database. 
Includes four text fields(Id, New Application Name, New User Name, New Comment) and also "Update" button.

#### Delete
Allows you to delete a record from database. 
Includes one text field(Id) and "Delete" button.

#### Database
Allows you to view database. Includes a window with a list and "Refresh" button. 
List of records shows after pressing a button.


### Functionality🕹

####- Insert
After inputing you all the data into text fields and pressing "Insert" button - record adds to database. 
Id of record generates automatically. 
All text fields are required. 
If at least one of the fields is empty, a warning window appears.

####- Update
To change a record, you must know its identifier. 
You can find the record ID on the "Database" tab or by working with the database file directly. 
After inputing you all the data into text fields and pressing "Update" button - record updates. 
All text fields are required. If at least one of the fields is empty, a warning window appears. 

####- Delete
To delete a record, you must know its identifier. 
You can find the record ID on the "Database" tab or by working with the database file directly.
After inputing you Id into text field and pressing "Delete" button - record deletes. 
Id is required. If Id's text field is empty a warning window appears. 

####- Database
After switching to the tab, the database is displayed only after clicking the "Refresh" button. 
The database is viewed in the form of a scrollable list display.

