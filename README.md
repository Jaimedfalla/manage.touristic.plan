# HOW TO INSTALL

1. First, You must create a database.env file inside Deployment folder with following environment variables

- POSTGRES_USER
- POSTGRES_PASSWORD

2. Create a service.file in same folder: Deployment with de variable
- CONNECTIONSTRINGS__PSQ_CONNECTION = CONNECTIONSTRINGS__PSQ_CONNECTION=User ID =${POSTGRES_USER};Password=${POSTGRES_PASSWORD};Server=instance-pgsql;Port=5432;Database=travelagency;Integrated Security=true;Pooling=true;

3. After, Create pgadmin.env inside Deployment folder with following environment variables

- PGADMIN_DEFAULT_EMAIL=__youremail__
- PGADMIN_DEFAULT_PASSWORD=__youradminpassword__

3. After, The script [install](/Deployment/install.ps1) must be executed.

# HOW TEST IT

You could check [Swagger UI service](http://localhost:8080/swagger)
You could logging to pgadmin [PG Admin](http://localhost:5050) with your credentials set in step 3