INSERT INTO VASS.PLAN(fk_airline, name, number_passenger_adult, number_passenger_children, end_date, price, discount, food, n_days)
VALUES (1, 'Cartagena de indias', 4, 5, '2022-12-22 19:10:25-07', 5000000, 30, TRUE, 5);
INSERT INTO VASS.PLAN(fk_airline, name, number_passenger_adult, number_passenger_children, end_date, price, discount, food, n_days)
VALUES (2, 'Carnaval de Barranquilla', 8, 4, '2023-09-22 19:10:22-07', 12000000, 20, TRUE, 10);
INSERT INTO VASS.PLAN(fk_airline, name, number_passenger_adult, number_passenger_children, end_date, price, discount, food, n_days)
VALUES (3, 'Medellin ciudad de las flores', 2, 1, '2023-10-22 19:10:23-07', 5000000, 5, FALSE, 10);
INSERT INTO VASS.PLAN(fk_airline, name, number_passenger_adult, number_passenger_children, end_date, price, discount, food, n_days)
VALUES (4, 'Carnaval de negros y blancos', 5, 3, '2023-11-22 19:10:28-07', 8000000, 5, FALSE, 8);
INSERT INTO VASS.PLAN(fk_airline, name, number_passenger_adult, number_passenger_children, end_date, price, discount, food, n_days)
VALUES (5, 'Bogogta Ciudad capital', 2, 4, '2023-06-22 19:10:24-07', 5000000,5, FALSE, 10);

-------------------------------------


INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (3, 'Gran malecon', 'Malecón junto al río', 'Riomar, Barranquilla, Atlántico');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (3, 'Museo del carnaval', ' ¡El Museo del Carnaval fue muy divertido, mirando los fabulosos vestidos usados por la Reina del Carnaval!', 'Cra. 54 #49B-39, Nte. Centro Historico, Barranquilla, Atlántico');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (3, 'Rio Magdalena', 'Paseo en barco', 'Riomar, Barranquilla, Atlántico');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (4, 'Ciudad amurallada', 'Obtenga una visión íntima de los históricos monumentos y calles de Cartagena', 'Cra. 2, San Diego, Cartagena de Indias, Provincia de Cartagena, Bolívar');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (4, 'Islas del rosario', 'Viaje desde la costa de Colombia en lancha motora hasta el Parque Nacional Corales del Rosario', 'Isla Grande, Archipielago de las islas del Rosario y de San Bernardo, Isla Grande');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (2, 'Guatape', 'Podrá explorar las coloridas calles de Guatapé y sus famosos zócalos, además de disfrutar de un exclusivo paseo en barco por el lago', 'Cl. 32 #29-61, Guatape, Guatapé, Antioquia');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (2, 'Ciudad Graffiti', 'La Comuna 13 es actualmente el sitio mas visitado en todo Medellín', '115 A, Cl 34C #228, Medellín, Antioquia');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (2, 'Piedra del peñol', 'El emplazamiento de la magnífica Piedra del Peñol', 'Guatapé, Antioquia');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (2, 'Equitacion', 'Paseos a caballo', 'Guatapé, Antioquia');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (10, 'Laguna de cocha', 'La Laguna de la Cocha, un lugar de descanso, siempre es hermoso y no se cansa uno de visitar', 'Vereda Santa Clara, Corregimiento el Encano, Puerto El Encanto, NAR');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (10, 'Museo del carnaval', 'el museo en sí es muy lindo, tiene historia, color y mucha cultura.', 'Cl 19 #42-60, Pasto, Nariño');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (10, 'Iglesia San Felipe', 'Es un lugar muy tranquilo para hacer oración, para reflexiones espirituales es perfecto.', 'Cra. 27 #12-41, Pasto, Nariño');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (5, 'Cerro Monserrate', 'Un lugar que se debe visitar al ir a Bogota, desde acá podemos ver toda la ciudad de norte a sur.', 'Dg. 6, Bogotá');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (5, 'Barrio La candelaria', 'La visita al barrio La Candelaria es obligada y altamente recomendada cuando viajes a Bogotá. Edificios muy bellos ideales para unas lindas fotos.', 'Cl. 11 #4-41, Bogotá');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (5, 'Guatavita', 'lago Guatavita', 'Guatavita, Cundinamarca');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (5, 'Catedral de sal', 'visita a la Catedral de sal de Zipaquirá', 'Zipaquirá, Cundinamarca');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (1, 'Cultura y naturaleza', 'onocerá la fábrica de oxígeno más grande y natural del planeta y será testigo de su majestuosidad. Tendrás la oportunidad de explorar el gran río Amazonas y su selva inundada, caminatas diurnas y nocturnas a través de bosques de árboles gigantes, navegar el lago de Tarapoto, “cuna de delfines” y también conocerás la vida tranquila de las comunidades indígenas cercanas', 'Leticia, Amazonas');
INSERT INTO VASS.TOURISTIC_PLACES(fk_city, name, description, location)
VALUES (13, 'Avistamiento de ballenas', 'navegar al lado de las Ballenas es sin lugar a dudas una de esas cosas que necesitas hacer en tu vida, Visitar cascadas y playas hermosas que muy seguramente no sabías que existían', 'Buenaventura');
	  
