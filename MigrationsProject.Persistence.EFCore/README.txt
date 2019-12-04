Our goal is to
- keep the DbContext and the migrations in their own assembly
- run the migrations as part of the deployment script rather than any specific webapp

In order to use it set startup project to your MigrationHelper Project

	- Messaging.Samples.Persistence.EFCore.MigrationHelper

From the Package Manager Console

    - Set DefaultProject to Persistence.EFCore
	
To Add a Migration

	- Add-Migration Intitial

To Update the database

	- Update-Databae
	
