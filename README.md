# HOW TO INSTALL

1. First, You must create a service.env file inside Deployment folder with following environment variables

- CONNECTIONSTRINGS__PSQ_CONNECTION = User ID =Repressed;Password=9xjGnCA4UbKDLL;Server=instance-pgsql;Port=5432;Database=travelagency;Integrated Security=true;Pooling=true;

2. After, Create pgadmin.env inside Deployment folder with following environment variables

- PGADMIN_DEFAULT_EMAIL=__youremail__
- PGADMIN_DEFAULT_PASSWORD=__youradminpassword__

3. After, The script [install](/Deployment/install.ps1) must be executed.

# HOW TEST IT

You could check [Swagger UI service](http://localhost:8080/swagger)
You could logging to pgadmin [PG Admin](http://localhost:5050) with your credentials set in step 3