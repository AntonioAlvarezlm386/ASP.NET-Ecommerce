USE DWEcommerce

INSERT INTO [USER](NAME, LAST_NAME, EMAIL, PASSWORD)
VALUES('Dev', 'Access', 'dev@email.com', '65e84be33532fb784c48129675f9eff3a682b27168c0ea744b2cf58ee02337c5')


INSERT INTO CATEGORY(DESCRIPTION)
VALUES 
	('Tecnologia'),
	('Muebles'),
	('Dormitorio'),
	('Deportes')



INSERT INTO BRAND(DESCRIPTION)
VALUES 
	('Sonytesty'),
	('HPtest'),
	('LGtest'),
	('Hyundaitest'),
	('Cannontest'),
	('Robbert Allentest')


INSERT INTO [STATE](STATE_ID, DESCRIPTION)
VALUES
	('01','Campeche'),
	('02','Chiapas'),
	('03','Puebla')


INSERT INTO CITY(CITY_ID, DESCRIPTION, STATE_ID)
VALUES 
	('0101','Escarcega','01'),
	('0102','Palizada','02'),

	('0201','Comitan de Dominguez','01'),
	('0202','Tuxtla Gutierrez','02'),

	('0301','Acatlan','01'),
	('0302','Guadalupe','02')



INSERT INTO LOCALITY(LOCALITY_ID, DESCRIPTION, CITY_ID, STATE_ID)
VALUES
	('010101','Escondido','0101','01'),
	('010102','Palma Sola','0101','02'),
	('010201','Santa Isabel','0102','01'),
	('010202','Tila','0102','02'),

	('020101','San Jose','0201','01'),
	('020102','El Valle','0201','02'),
	('020201','Teran','0202','01'),
	('020202','San Vicente','0202','02'),

	('030101','Las Nieves','0301','01'),
	('030102','La Huerta','0301','02'),
	('030201','El Limon','0302','01'),
	('030202','Saa Antonio','0302','02')


