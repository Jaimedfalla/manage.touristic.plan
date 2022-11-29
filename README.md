To build the image, you must execute this command. Before, you should be located in path solution inside console.

- docker build -t jaefallac/tourismplan:latest -f manage.touristic.plan.Api\Dockerfile .

To run the container, you must use this command

- docker run --name touristic-plan-api -e ConnectionStrings__PSQ_connection="User ID =__\<user\>__;Password=__\<password\>__ ; Server=__\<server\>__;Port=__\<port\>__;Database=__\<database\>__; Integrated Security=true;Pooling=true;" -p 8080:80 -d jaefallac/tourismplan

> Where __\<user\>__ is user to connect database VassAgency. __\<password\>__ is user password before mentioned. __\<port\>: Port is listening your postgresql instance. __\<server\>__: Server of your instance

Other commands
docker run --name postgresql-instance -p 5432:5432 -e POSTGRES_USER=postgres -e POSTGRES_PASSWORD=<password> -e POSTGRES_DB=<instance-name> -d postgres
docker run --name pgadmin -p 80:80 -e 'PGADMIN_DEFAULT_EMAIL=<email-admin>' -e 'PGADMIN_DEFAULT_PASSWORD=<password-admin>' -d dpage/pgadmin4

