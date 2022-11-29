To build the image, you must execute this command. Before, you should be located in path solution inside console.

- docker build -t jaefallac/tourismplan:latest -f manage.touristic.plan.Api\Dockerfile .

To run the container, you must use this command

- docker run --name dev-touristic-plan-api -e ConnectionStrings__PSQ_connection="User ID =<user>;Password=<password>;Server=<server>;Port=<port>;Database=VassAgency; Integrated Security=true;Pooling=true;" -p 8080:80 -d jaefallac/tourismplan

> Where <user> is user to connect database VassAgency. <password> is user password before mentioned. <port>: Port is listening your postgresql instance. <server>: Server of your instance

Other commands
docker run --name postgresql-instance -p 5432:5432 -e POSTGRES_USER=postgres -e POSTGRES_PASSWORD=<password> -e POSTGRES_DB=<instance-name> -d postgres
docker run --name pgadmin -p 80:80 -e 'PGADMIN_DEFAULT_EMAIL=<email-admin>' -e 'PGADMIN_DEFAULT_PASSWORD=<password-admin>' -d dpage/pgadmin4

