# DAS Barangay Sto. Domingo Piat — Database Documentation

## Connection Details

| Property          | Value                                      |
|-------------------|--------------------------------------------|
| Server            | `Glenn\SQLEXPRESS`                         |
| Database Name     | `dasbsdp`                                  |
| Authentication    | Windows Authentication (Integrated Security) |
| Connection String | `Data Source=Glenn\SQLEXPRESS;Initial Catalog=dasbsdp;Integrated Security=True;TrustServerCertificate=True;` |

---

## Tables Overview

| Table           | Description                                          |
|-----------------|------------------------------------------------------|
| `tbl_Users`     | Stores all admin and user accounts                   |
| `tbl_Documents` | Stores all uploaded barangay documents               |
| `tbl_ActivityLogs` | Stores system activity and audit trail logs       |

---

## Table Definitions

### 1. `tbl_Users`
Stores all registered accounts (Admin and User roles).

| Column              | Data Type       | Constraints              | Description                                      |
|---------------------|-----------------|--------------------------|--------------------------------------------------|
| `UserID`            | `INT`           | PK, IDENTITY(1,1)        | Auto-incremented primary key                     |
| `UserCode`          | `VARCHAR(10)`   | NOT NULL, UNIQUE         | Formatted code e.g. `USR-0001`                   |
| `Username`          | `VARCHAR(50)`   | NOT NULL, UNIQUE         | Login username                                   |
| `PasswordHash`      | `VARCHAR(255)`  | NOT NULL                 | Hashed password (plain text for demo)            |
| `UserType`          | `VARCHAR(10)`   | NOT NULL                 | `Admin` or `User`                                |
| `SecurityQuestion`  | `VARCHAR(255)`  | NOT NULL                 | Selected security question for password recovery |
| `SecurityAnswer`    | `VARCHAR(100)`  | NOT NULL                 | Answer to the security question                  |
| `Status`            | `VARCHAR(10)`   | NOT NULL, DEFAULT `Active` | `Active` or `Inactive`                         |
| `CreatedAt`         | `DATETIME`      | NOT NULL, DEFAULT `GETDATE()` | Date and time the account was created       |

---

### 2. `tbl_Documents`
Stores all barangay documents uploaded by users.

| Column           | Data Type       | Constraints                  | Description                                         |
|------------------|-----------------|------------------------------|-----------------------------------------------------|
| `DocumentID`     | `INT`           | PK, IDENTITY(1,1)            | Auto-incremented primary key                        |
| `DocumentCode`   | `VARCHAR(15)`   | NOT NULL, UNIQUE             | Formatted code e.g. `DOC-0001`                      |
| `Title`          | `VARCHAR(255)`  | NOT NULL                     | Document title                                      |
| `Description`    | `NVARCHAR(MAX)` | NULL                         | Optional description or summary                     |
| `DocumentType`   | `VARCHAR(50)`   | NOT NULL                     | `Ordinance`, `Resolution`, `Budget Report`, etc.    |
| `BannerImage`    | `VARBINARY(MAX)`| NULL                         | Uploaded image banner (binary)                      |
| `PDFFileName`    | `VARCHAR(255)`  | NULL                         | Original filename of the uploaded PDF               |
| `PDFFile`        | `VARBINARY(MAX)`| NULL                         | Uploaded PDF document (binary)                      |
| `UploadedBy`     | `VARCHAR(50)`   | NOT NULL                     | Username of the uploader (FK → `tbl_Users.Username`)|
| `DateUploaded`   | `DATETIME`      | NOT NULL, DEFAULT `GETDATE()`| Date and time the document was uploaded             |
| `ApprovalStatus` | `VARCHAR(20)`   | NOT NULL, DEFAULT `For Review` | `For Review`, `Approved`, `Archived`              |
| `Status`         | `VARCHAR(10)`   | NOT NULL, DEFAULT `Active`   | `Active` or `Archived`                              |

---

### 3. `tbl_ActivityLogs`
Stores a full audit trail of system events.

| Column        | Data Type       | Constraints                   | Description                                         |
|---------------|-----------------|-------------------------------|-----------------------------------------------------|
| `LogID`       | `INT`           | PK, IDENTITY(1,1)             | Auto-incremented primary key                        |
| `LogCode`     | `VARCHAR(10)`   | NOT NULL, UNIQUE              | Formatted code e.g. `LOG-0001`                      |
| `Username`    | `VARCHAR(50)`   | NOT NULL                      | Username who performed the action (FK → `tbl_Users.Username`) |
| `LogDate`     | `DATETIME`      | NOT NULL, DEFAULT `GETDATE()` | Date and time the event occurred                    |
| `Result`      | `VARCHAR(10)`   | NOT NULL                      | `Success` or `Failed`                               |
| `Description` | `NVARCHAR(MAX)` | NOT NULL                      | Human-readable description of the event             |

---

## Relationships

```
tbl_Users (UserID PK)
    |
    |-- tbl_Documents.UploadedBy  --> tbl_Users.Username
    |
    +-- tbl_ActivityLogs.Username --> tbl_Users.Username
```

| Relationship                             | Type       | Description                                      |
|------------------------------------------|------------|--------------------------------------------------|
| `tbl_Documents.UploadedBy` → `tbl_Users.Username` | Many-to-One | A user can upload many documents          |
| `tbl_ActivityLogs.Username` → `tbl_Users.Username` | Many-to-One | A user can have many activity log entries |

---

## SQL Creation Script

Copy and run this in **SQL Server Management Studio (SSMS)** after connecting to `Glenn\SQLEXPRESS`.

```sql
-- ============================================================
--  DAS Barangay Sto. Domingo Piat
--  Database: dasbsdp
--  Server:   Glenn\SQLEXPRESS
-- ============================================================

USE master;
GO

-- Create database if it does not exist
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'dasbsdp')
BEGIN
    CREATE DATABASE dasbsdp;
END
GO

USE dasbsdp;
GO

-- ============================================================
--  TABLE: tbl_Users
-- ============================================================
IF OBJECT_ID('tbl_Users', 'U') IS NULL
BEGIN
    CREATE TABLE tbl_Users (
        UserID           INT           NOT NULL IDENTITY(1,1),
        UserCode         VARCHAR(10)   NOT NULL,
        Username         VARCHAR(50)   NOT NULL,
        PasswordHash     VARCHAR(255)  NOT NULL,
        UserType         VARCHAR(10)   NOT NULL,
        SecurityQuestion VARCHAR(255)  NOT NULL,
        SecurityAnswer   VARCHAR(100)  NOT NULL,
        Status           VARCHAR(10)   NOT NULL CONSTRAINT DF_Users_Status DEFAULT ('Active'),
        CreatedAt        DATETIME      NOT NULL CONSTRAINT DF_Users_CreatedAt DEFAULT (GETDATE()),

        CONSTRAINT PK_Users       PRIMARY KEY (UserID),
        CONSTRAINT UQ_Users_Code  UNIQUE      (UserCode),
        CONSTRAINT UQ_Users_Name  UNIQUE      (Username),
        CONSTRAINT CK_Users_Type  CHECK       (UserType   IN ('Admin', 'User')),
        CONSTRAINT CK_Users_Stat  CHECK       (Status     IN ('Active', 'Inactive'))
    );
END
GO

-- ============================================================
--  TABLE: tbl_Documents
-- ============================================================
IF OBJECT_ID('tbl_Documents', 'U') IS NULL
BEGIN
    CREATE TABLE tbl_Documents (
        DocumentID      INT             NOT NULL IDENTITY(1,1),
        DocumentCode    VARCHAR(15)     NOT NULL,
        Title           VARCHAR(255)    NOT NULL,
        Description     NVARCHAR(MAX)   NULL,
        DocumentType    VARCHAR(50)     NOT NULL,
        BannerImage     VARBINARY(MAX)  NULL,
        PDFFileName     VARCHAR(255)    NULL,
        PDFFile         VARBINARY(MAX)  NULL,
        UploadedBy      VARCHAR(50)     NOT NULL,
        DateUploaded    DATETIME        NOT NULL CONSTRAINT DF_Docs_DateUploaded DEFAULT (GETDATE()),
        ApprovalStatus  VARCHAR(20)     NOT NULL CONSTRAINT DF_Docs_Approval     DEFAULT ('For Review'),
        Status          VARCHAR(10)     NOT NULL CONSTRAINT DF_Docs_Status       DEFAULT ('Active'),

        CONSTRAINT PK_Documents        PRIMARY KEY (DocumentID),
        CONSTRAINT UQ_Documents_Code   UNIQUE      (DocumentCode),
        CONSTRAINT CK_Docs_Approval    CHECK       (ApprovalStatus IN ('For Review', 'Approved', 'Archived')),
        CONSTRAINT CK_Docs_Status      CHECK       (Status         IN ('Active', 'Archived')),
        CONSTRAINT FK_Docs_UploadedBy  FOREIGN KEY (UploadedBy) REFERENCES tbl_Users(Username)
    );
END
GO

-- ============================================================
--  TABLE: tbl_ActivityLogs
-- ============================================================
IF OBJECT_ID('tbl_ActivityLogs', 'U') IS NULL
BEGIN
    CREATE TABLE tbl_ActivityLogs (
        LogID       INT            NOT NULL IDENTITY(1,1),
        LogCode     VARCHAR(10)    NOT NULL,
        Username    VARCHAR(50)    NOT NULL,
        LogDate     DATETIME       NOT NULL CONSTRAINT DF_Logs_LogDate DEFAULT (GETDATE()),
        Result      VARCHAR(10)    NOT NULL,
        Description NVARCHAR(MAX)  NOT NULL,

        CONSTRAINT PK_ActivityLogs       PRIMARY KEY (LogID),
        CONSTRAINT UQ_ActivityLogs_Code  UNIQUE      (LogCode),
        CONSTRAINT CK_Logs_Result        CHECK       (Result IN ('Success', 'Failed')),
        CONSTRAINT FK_Logs_Username      FOREIGN KEY (Username) REFERENCES tbl_Users(Username)
    );
END
GO

-- ============================================================
--  SEED DATA: tbl_Users
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM tbl_Users)
BEGIN
    INSERT INTO tbl_Users (UserCode, Username, PasswordHash, UserType, SecurityQuestion, SecurityAnswer, Status)
    VALUES
        ('USR-0001', 'admin',   '$2a$11$zrfWgscm52K3Cg5iYuvTMuUMs3ISKhG2bT6Fz7tWLW7i8IPhuQ88C', 'Admin', 'What is your mother''s maiden name?',      'Santos',  'Active'),
        ('USR-0002', 'jdela',   '$2a$11$eu9P4dEGU8E0Afb2K3H0leXtbCWUtavG1VjfKQOPv1tq6mOINf1fa', 'User',  'What is your mother''s maiden name?',      'Santos',  'Active'),
        ('USR-0003', 'mreyes',  '$2a$11$uLoVubSKvSo0S5M1HZuvhuo1hmT4.WMP1uDhxlzZ91/otyoj9NdrG', 'User',  'What was the name of your first pet?',     'Brownie', 'Active'),
        ('USR-0004', 'rsantos', '$2a$11$EtgScj4iLSvWM/7PQgKp3.Bh1JZqkTehKWsA0iIGhxw43dN3o5Ame', 'User',  'What is your elementary school name?',     'BSPES',   'Inactive'),
        ('USR-0005', 'bcruz',   '$2a$11$TuU3tY4ilPcJP35NHykizOLu3ouAAcsd8LwKcaGuUNy5fh5iUo9iW', 'User',  'What city were you born in?',              'Piat',    'Active'),
        ('USR-0006', 'lgarcia', '$2a$11$jg0.wM67Q8J1Awi/Skee5ukJtlpbB.XfoSwyf9c6MkBXVNK9pXxoS', 'Admin', 'What is your favorite childhood nickname?','Garci',   'Active'),
        ('USR-0007', 'ptorres', '$2a$11$UYvM0OAj2oyfMew1YBH8vejt/vHNdJF2lgba79WmhEj/QtVB055vq', 'User',  'What was the name of your first pet?',     'Spotty',  'Inactive');
END
GO

-- ============================================================
--  SEED DATA: tbl_Documents
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM tbl_Documents)
BEGIN
    INSERT INTO tbl_Documents (DocumentCode, Title, DocumentType, UploadedBy, DateUploaded, ApprovalStatus, Status)
    VALUES
        ('DOC-0001', 'Barangay Resolution No. 01',  'Legal Documents',                 'admin',   '2025-01-10 08:30', 'Approved',   'Active'),
        ('DOC-0002', 'Community Development Plan',   'Legal Documents',                 'jdela',   '2025-01-15 09:00', 'Approved',   'Active'),
        ('DOC-0003', 'Infrastructure Project Docs',  'Project & Operational Documents', 'mreyes',  '2025-02-03 10:15', 'Approved',   'Active'),
        ('DOC-0004', 'Health Program Report 2024',   'Technical & Medical Records',     'admin',   '2025-02-20 11:00', 'Archived',   'Archived'),
        ('DOC-0005', 'Livelihood Program Proposal',  'Project & Operational Documents', 'rsantos', '2025-03-05 14:30', 'For Review', 'Active'),
        ('DOC-0006', 'Solid Waste Management Plan',  'Correspondence',                  'jdela',   '2025-03-18 09:45', 'Archived',   'Archived'),
        ('DOC-0007', 'Barangay Budget FY 2025',      'Financial Documents',             'admin',   '2025-04-01 08:00', 'Approved',   'Active');
END
GO

-- ============================================================
--  SEED DATA: tbl_ActivityLogs
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM tbl_ActivityLogs)
BEGIN
    INSERT INTO tbl_ActivityLogs (LogCode, Username, LogDate, Result, Description)
    VALUES
        ('LOG-0001', 'admin',   '2025-01-10 08:31', 'Success', 'Admin logged in successfully.'),
        ('LOG-0002', 'jdela',   '2025-01-15 09:02', 'Success', 'User uploaded a new document.'),
        ('LOG-0003', 'mreyes',  '2025-02-03 10:20', 'Success', 'User updated document DOC-0003.'),
        ('LOG-0004', 'rsantos', '2025-02-18 14:05', 'Failed',  'Login attempt failed - wrong password.'),
        ('LOG-0005', 'admin',   '2025-02-20 11:10', 'Success', 'Admin deleted document DOC-0004.'),
        ('LOG-0006', 'bcruz',   '2025-03-01 08:45', 'Success', 'User logged in successfully.'),
        ('LOG-0007', 'lgarcia', '2025-03-10 09:30', 'Failed',  'Login attempt failed - account inactive.');
END
GO
```

---

## How to Import in SSMS

1. Open **SQL Server Management Studio (SSMS)**
2. Connect to server: `Glenn\SQLEXPRESS` using **Windows Authentication**
3. Click **New Query**
4. Copy the entire SQL script from the section above and paste it into the query window
5. Press **F5** or click **Execute**
6. The database `dasbsdp`, all three tables, and all seed data will be created automatically

---

## Security Questions List

Used in both profile update and forgot password forms:

1. What is your mother's maiden name?
2. What was the name of your first pet?
3. What is your elementary school name?
4. What city were you born in?
5. What is your favorite childhood nickname?

---

## Document Types List

Defined in `Helpers/Constants.vb` (`DocumentTypes`) and shared by the `AdminNewDocumentForm`, `AdminUpdateDocumentForm`, and `UserUploadDocumentPanel` dropdowns:

| Value                              |
|-------------------------------------|
| `Financial Documents`               |
| `Legal Documents`                   |
| `Human Resources (HR) Documents`    |
| `Project & Operational Documents`   |
| `Correspondence`                    |
| `Intellectual Property`             |
| `Customer & Client Records`         |
| `Technical & Medical Records`       |

---

*Last updated: 2026*
