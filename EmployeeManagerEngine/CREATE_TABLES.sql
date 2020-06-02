﻿CREATE TABLE GENDER (
	id INT NOT NULL identity(1,1) CONSTRAINT PK_GENDER PRIMARY KEY (id),
	description VARCHAR(50) NOT NULL,
	is_active BIT NOT NULL CONSTRAINT DF_GENDER_is_active DEFAULT 1,
	last_modified DATETIME NOT NULL CONSTRAINT DF_GENDER_last_modified DEFAULT getdate()
);

CREATE TABLE SKILL (
	id INT NOT NULL identity(1,1) CONSTRAINT PK_SKILL PRIMARY KEY (id),
	description VARCHAR(50) NOT NULL,
	is_active BIT NOT NULL CONSTRAINT DF_SKILL_is_active DEFAULT 1,
	last_modified DATETIME NOT NULL CONSTRAINT DF_SKILL_last_modified DEFAULT getdate()
);

CREATE TABLE EMPLOYEE (
	id INT NOT NULL identity(1,1) CONSTRAINT PK_EMPLOYEE PRIMARY KEY (id),
	gender_id INT NOT NULL CONSTRAINT FK_EMPLOYEE_GENDER REFERENCES GENDER(id),
	is_active BIT NOT NULL CONSTRAINT DF_EMPLOYEE_is_active DEFAULT 1,
	last_modified DATETIME NOT NULL CONSTRAINT DF_EMPLOYEE_last_modified DEFAULT getdate(),
	name VARCHAR(50) NOT NULL,
	last_name VARCHAR(100) NOT NULL,
	born_date DATETIME NOT NULL,
	email varchar(100)
);

CREATE TABLE EMPLOYEE_SKILL (
    skill_id INT NOT NULL CONSTRAINT FK_EMPLOYEE_SKILL_SKILL REFERENCES SKILL(id),
    employee_id INT NOT NULL CONSTRAINT FK_EMPLOYEE_SKILL_EMPLOYEE REFERENCES EMPLOYEE(id),
    CONSTRAINT PK_EMPLOYEE_SKILL PRIMARY KEY (skill_id, employee_id)
);

INSERT INTO GENDER (description) values ('Masculino') , ('Feminino');

INSERT INTO SKILL (description) values ('C#'), ('Java'), ('Angular'), ('SQL'), ('ASP');