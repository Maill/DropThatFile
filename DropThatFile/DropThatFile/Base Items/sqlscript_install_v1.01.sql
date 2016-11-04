/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: accounts
------------------------------------------------------------*/
CREATE TABLE accounts(
	id        INT IDENTITY (1,1) NOT NULL ,
	fname     VARCHAR (30) NOT NULL ,
	lname     VARCHAR (30) NOT NULL ,
	mail      VARCHAR (100) NOT NULL ,
	password  VARCHAR (50) NOT NULL ,
	lastLogin DATETIME NOT NULL ,
	CONSTRAINT prk_constraint_accounts PRIMARY KEY NONCLUSTERED (id)
);


/*------------------------------------------------------------
-- Table: files
------------------------------------------------------------*/
CREATE TABLE files(
	id      INT IDENTITY (1,1) NOT NULL ,
	name    VARCHAR (50) NOT NULL ,
	pass    VARCHAR (200) NOT NULL ,
	created DATETIME NOT NULL ,
	description VARCHAR(200) ,
	CONSTRAINT prk_constraint_files PRIMARY KEY NONCLUSTERED (id)
);


/*------------------------------------------------------------
-- Table: groups
------------------------------------------------------------*/
CREATE TABLE groups(
	id   INT IDENTITY (1,1) NOT NULL ,
	name VARCHAR (50) NOT NULL ,
	CONSTRAINT prk_constraint_groups PRIMARY KEY NONCLUSTERED (id)
);


/*------------------------------------------------------------
-- Table: filesOfAccount
------------------------------------------------------------*/
CREATE TABLE filesOfAccount(
	shared    bit  NOT NULL ,
	id_account  INT  NOT NULL ,
	id_files  INT  NOT NULL ,
	id_groups INT  NOT NULL ,
	CONSTRAINT prk_constraint_filesOfAccount PRIMARY KEY NONCLUSTERED (id_account,id_files,id_groups)
);


/*------------------------------------------------------------
-- Table: membersOf
------------------------------------------------------------*/
CREATE TABLE membersOf(
	id_account   INT  NOT NULL ,
	id_groups INT  NOT NULL ,
	isAdmin bit	,
	CONSTRAINT prk_constraint_membersOf PRIMARY KEY NONCLUSTERED (id_account,id_groups)
);


/*------------------------------------------------------------
-- Table: childOf
------------------------------------------------------------*/
CREATE TABLE childOf(
	id_child        INT  NOT NULL ,
	id_master	 INT  NOT NULL ,
	CONSTRAINT prk_constraint_childOf PRIMARY KEY NONCLUSTERED (id_child,id_master)
);



ALTER TABLE filesOfAccount ADD CONSTRAINT FK_filesOfAccount_id_account FOREIGN KEY (id_account) REFERENCES accounts(id);
ALTER TABLE filesOfAccount ADD CONSTRAINT FK_filesOfAccount_id_files FOREIGN KEY (id_files) REFERENCES files(id);
ALTER TABLE filesOfAccount ADD CONSTRAINT FK_filesOfAccount_id_groups FOREIGN KEY (id_groups) REFERENCES groups(id);
ALTER TABLE membersOf ADD CONSTRAINT FK_membersOf_id_account FOREIGN KEY (id_account) REFERENCES accounts(id);
ALTER TABLE membersOf ADD CONSTRAINT FK_membersOf_id_groups FOREIGN KEY (id_groups) REFERENCES groups(id);
ALTER TABLE childOf ADD CONSTRAINT FK_childOf_id FOREIGN KEY (id_child) REFERENCES groups(id);
ALTER TABLE childOf ADD CONSTRAINT FK_childOf_id_groups FOREIGN KEY (id_master) REFERENCES groups(id);
