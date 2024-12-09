CREATE TABLE "__EFMigrationsHistory" (
	"MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY
	,"ProductVersion" TEXT NOT NULL
	);

SELECT COUNT(*)
FROM "sqlite_master"
WHERE "name" = '__EFMigrationsHistory'
	AND "type" = 'table';

SELECT "MigrationId"
	,"ProductVersion"
FROM "__EFMigrationsHistory"
ORDER BY "MigrationId";

CREATE TABLE "tblSettings" (
	"Id" INTEGER NOT NULL CONSTRAINT "PK_tblSettings" PRIMARY KEY AUTOINCREMENT
	,"Name" TEXT NOT NULL
	,"Description" TEXT NOT NULL
	,"CreatedDate" TEXT NOT NULL
	,"UpdatedDate" TEXT NULL
	);

CREATE TABLE "tblUrlList" (
	"Id" INTEGER NOT NULL CONSTRAINT "PK_tblUrlList" PRIMARY KEY AUTOINCREMENT
	,"Name" TEXT NOT NULL
	,"Url" TEXT NOT NULL
	,"ReqType" TEXT NOT NULL
	,"ReqJson" TEXT NOT NULL
	,"CreatedDate" TEXT NOT NULL
	,"UpdatedDate" TEXT NULL
	);

INSERT INTO "tblSettings" (
	"Id"
	,"CreatedDate"
	,"Description"
	,"Name"
	,"UpdatedDate"
	)
VALUES (
	1
	,'2024-12-09 15:35:02.0885835'
	,''
	,'BaseUrl'
	,NULL
	);

INSERT INTO "__EFMigrationsHistory" (
	"MigrationId"
	,"ProductVersion"
	)
VALUES (
	'20241019170343_urlList'
	,'8.0.10'
	);

CREATE TABLE "tblParameters" (
	"Id" INTEGER NOT NULL CONSTRAINT "PK_tblParameters" PRIMARY KEY AUTOINCREMENT
	,"Name" TEXT NOT NULL
	,"Type" TEXT NOT NULL
	,"Source" TEXT NOT NULL
	,"PathValue" TEXT NOT NULL
	,"FinalValue" TEXT NOT NULL
	,"CreatedDate" TEXT NOT NULL
	,"UpdatedDate" TEXT NULL
	);

INSERT INTO "__EFMigrationsHistory" (
	"MigrationId"
	,"ProductVersion"
	)
VALUES (
	'20241020173901_ParameterTable'
	,'8.0.10'
	);

CREATE TABLE "tblHeaders" (
	"Id" INTEGER NOT NULL CONSTRAINT "PK_tblHeaders" PRIMARY KEY AUTOINCREMENT
	,"HeaderKey" TEXT NOT NULL
	,"HeaderValue" TEXT NOT NULL
	);

UPDATE "tblSettings"
SET "CreatedDate" = '2024-12-09 15:35:02.5925755'
WHERE "Id" = 1;

INSERT INTO "tblSettings" (
	"Id"
	,"CreatedDate"
	,"Description"
	,"Name"
	,"UpdatedDate"
	)
VALUES (
	2
	,'2024-12-09 15:35:02.5925821'
	,''
	,'LoginReqType'
	,NULL
	);

INSERT INTO "tblSettings" (
	"Id"
	,"CreatedDate"
	,"Description"
	,"Name"
	,"UpdatedDate"
	)
VALUES (
	3
	,'2024-12-09 15:35:02.5925826'
	,''
	,'LoginUrl'
	,NULL
	);

INSERT INTO "tblSettings" (
	"Id"
	,"CreatedDate"
	,"Description"
	,"Name"
	,"UpdatedDate"
	)
VALUES (
	4
	,'2024-12-09 15:35:02.5925828'
	,''
	,'LoginReqJson'
	,NULL
	);

INSERT INTO "tblSettings" (
	"Id"
	,"CreatedDate"
	,"Description"
	,"Name"
	,"UpdatedDate"
	)
VALUES (
	5
	,'2024-12-09 15:35:02.592583'
	,''
	,'LoginRespJson'
	,NULL
	);

INSERT INTO "__EFMigrationsHistory" (
	"MigrationId"
	,"ProductVersion"
	)
VALUES (
	'20241124074110_tblHeaders'
	,'8.0.10'
	);

ALTER TABLE "tblHeaders" ADD "CreatedDate" TEXT NOT NULL DEFAULT '2024-12-09 15:35:04.0979777';

ALTER TABLE "tblHeaders" ADD "HeaderFinalValue" TEXT NOT NULL DEFAULT '';

ALTER TABLE "tblHeaders" ADD "UpdatedDate" TEXT NULL;

INSERT INTO "__EFMigrationsHistory" (
	"MigrationId"
	,"ProductVersion"
	)
VALUES (
	'20241129161616_HeaderTableDetails'
	,'8.0.10'
	);

ALTER TABLE "tblParameters" ADD "urlId" INTEGER NULL;

ALTER TABLE "tblHeaders" ADD "urlId" INTEGER NULL;

CREATE INDEX "IX_tblParameters_urlId" ON "tblParameters" ("urlId");

CREATE INDEX "IX_tblHeaders_urlId" ON "tblHeaders" ("urlId");

CREATE TABLE "ef_temp_tblHeaders" (
	"Id" INTEGER NOT NULL CONSTRAINT "PK_tblHeaders" PRIMARY KEY AUTOINCREMENT
	,"CreatedDate" TEXT NOT NULL
	,"HeaderFinalValue" TEXT NOT NULL
	,"HeaderKey" TEXT NOT NULL
	,"HeaderValue" TEXT NOT NULL
	,"UpdatedDate" TEXT NULL
	,"urlId" INTEGER NULL
	,CONSTRAINT "FK_tblHeaders_tblUrlList_urlId" FOREIGN KEY ("urlId") REFERENCES "tblUrlList" ("Id")
	);

INSERT INTO "ef_temp_tblHeaders" (
	"Id"
	,"CreatedDate"
	,"HeaderFinalValue"
	,"HeaderKey"
	,"HeaderValue"
	,"UpdatedDate"
	,"urlId"
	)
SELECT "Id"
	,"CreatedDate"
	,"HeaderFinalValue"
	,"HeaderKey"
	,"HeaderValue"
	,"UpdatedDate"
	,"urlId"
FROM "tblHeaders";

CREATE TABLE "ef_temp_tblParameters" (
	"Id" INTEGER NOT NULL CONSTRAINT "PK_tblParameters" PRIMARY KEY AUTOINCREMENT
	,"CreatedDate" TEXT NOT NULL
	,"FinalValue" TEXT NOT NULL
	,"Name" TEXT NOT NULL
	,"PathValue" TEXT NOT NULL
	,"Source" TEXT NOT NULL
	,"Type" TEXT NOT NULL
	,"UpdatedDate" TEXT NULL
	,"urlId" INTEGER NULL
	,CONSTRAINT "FK_tblParameters_tblUrlList_urlId" FOREIGN KEY ("urlId") REFERENCES "tblUrlList" ("Id")
	);

INSERT INTO "ef_temp_tblParameters" (
	"Id"
	,"CreatedDate"
	,"FinalValue"
	,"Name"
	,"PathValue"
	,"Source"
	,"Type"
	,"UpdatedDate"
	,"urlId"
	)
SELECT "Id"
	,"CreatedDate"
	,"FinalValue"
	,"Name"
	,"PathValue"
	,"Source"
	,"Type"
	,"UpdatedDate"
	,"urlId"
FROM "tblParameters";

PRAGMA foreign_keys = 0;

DROP TABLE "tblHeaders";

ALTER TABLE "ef_temp_tblHeaders" RENAME TO "tblHeaders";

DROP TABLE "tblParameters";

ALTER TABLE "ef_temp_tblParameters" RENAME TO "tblParameters";

PRAGMA foreign_keys = 1;

CREATE INDEX "IX_tblHeaders_urlId" ON "tblHeaders" ("urlId");

CREATE INDEX "IX_tblParameters_urlId" ON "tblParameters" ("urlId");

INSERT INTO "__EFMigrationsHistory" (
	"MigrationId"
	,"ProductVersion"
	)
VALUES (
	'20241205105651_urlIdInParamNsettings'
	,'8.0.10'
	);

DROP INDEX "IX_tblParameters_urlId";

DROP INDEX "IX_tblHeaders_urlId";

CREATE UNIQUE INDEX "IX_tblUrlList_Name" ON "tblUrlList" ("Name");

CREATE UNIQUE INDEX "IX_tblSettings_Name" ON "tblSettings" ("Name");

CREATE UNIQUE INDEX "IX_tblParameters_urlId_Name" ON "tblParameters" (
	"urlId"
	,"Name"
	);

CREATE UNIQUE INDEX "IX_tblHeaders_urlId_HeaderKey" ON "tblHeaders" (
	"urlId"
	,"HeaderKey"
	);

INSERT INTO "__EFMigrationsHistory" (
	"MigrationId"
	,"ProductVersion"
	)
VALUES (
	'20241209083240_indexesUnique'
	,'8.0.10'
	);
