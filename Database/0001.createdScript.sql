CREATE SCHEMA IF NOT EXISTS VASS;

CREATE TABLE VASS.CUSTOMERS (
	DNI character varying PRIMARY KEY,
	fullname character varying(100) NOT NULL,
	phone character varying(10) NOT NULL,
	email character varying(70) NOT NULL,
	address character varying(100) NOT NULL
);

CREATE TABLE VASS.airlines (
	id_airline INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	name character varying(80) NOT NULL
);

CREATE TABLE VASS.hotels (
	id_hotel INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	name character varying(80) NOT NULL
);

CREATE TABLE VASS.cities (
	id_city INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	name character varying(80) NOT NULL
);

CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

CREATE TABLE VASS.PLAN (
	id_plan uuid DEFAULT uuid_generate_v4 () PRIMARY KEY,
	fk_airline INT NOT NULL,
	name character varying(80) NOT NULL,
	number_passenger_adult INT NOT NULL,
	number_passenger_children INT DEFAULT 0,
	end_date TIMESTAMP NOT NULL,
	price MONEY,
	discount INT,
	food BOOLEAN,
	n_days INT NOT NULL,
	CONSTRAINT fk_airline
      FOREIGN KEY(fk_airline) 
	  REFERENCES VASS.airlines(id_airline)
);


CREATE TABLE VASS.PLAN_CUSTOMER (
	id uuid DEFAULT uuid_generate_v4 () PRIMARY KEY,
	fk_plan uuid NOT NULL,
	fk_customer character varying NOT NULL,
	start_date TIMESTAMP NOT NULL,
	CONSTRAINT fk_plan
      FOREIGN KEY(fk_plan) 
	  REFERENCES VASS.plan(id_plan),
	CONSTRAINT fk_customer
      FOREIGN KEY(fk_customer) 
	  REFERENCES VASS.customers(DNI)
);

CREATE TABLE VASS.TOURISTIC_PLACES (
	id_touristic_place INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	fk_city INT NOT NULL,
	name character varying(80) NOT NULL,
	description character varying(4000) NOT NULL,
	location TEXT NOT NULL,
	CONSTRAINT fk_city
      FOREIGN KEY(fk_city) 
	  REFERENCES VASS.cities(id_city)
);

CREATE TABLE VASS.ROADMAP (
	id_roadmap uuid DEFAULT uuid_generate_v4 () PRIMARY KEY,
	fk_plan uuid NOT NULL,
	fk_hotel INT NOT NULL,
	fk_touristic_place INT NOT NULL,
	destination character varying(80) NOT NULL,
	arrive_date TIMESTAMP NOT NULL,
	stay_days INT NOT NULL,
	CONSTRAINT fk_plan
      FOREIGN KEY(fk_plan) 
	  REFERENCES VASS.plan(id_plan),
	CONSTRAINT fk_hotel
      FOREIGN KEY(fk_hotel) 
	  REFERENCES VASS.hotels(id_hotel),
	CONSTRAINT fk_touristic_place
      FOREIGN KEY(fk_touristic_place) 
	  REFERENCES VASS.touristic_places(id_touristic_place)
);