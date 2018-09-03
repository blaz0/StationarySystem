Readme file:

INSTRUCTIONS ON HOW TO DEPLOY AND RUN THE SOFTWARE:
1. Ensure that SQL Server is installed.
2. Ensure that the database is named 'sepdb'
3. Create all the tables as per the scripts in the folo=lowing order (this is due to dependencies in the tables)
	1. users
	2. userroles
	3. supplierorder
	4. supplier
	5. product
	6. orderedproducts
	7. invoice
	8. stationeryrequest
	9. requestedstationery
4. The config file found in StationerySystem/bin/Debug needs to be edited so that the details in the config file 
match your database; in particular the name of the database, the username of the database and the password of the 
database.
5. Run the file, by clicking on the "StationarySystem.exe"

