First run migrations
dotnet ef database update --context AppDbContext

This will create all the tables and seed the database with some data.

There is one user already created in the SqLite IdentityDB:
email: admin@email.com
pass: Admin_24

If you want to create the Identity DB from scratch you can delete the ecommerce/ecommerce.db file and then run:
dotnet ef database update --context IdentityDbContext
