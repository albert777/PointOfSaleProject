CREATE TABLE Profiles_master (
PM_ID varchar(10),
PM_UserID varchar(10),
PM_Password varchar(10),
PM_FirstName varchar(10),
PM_LastName varchar(10),
PM_Gender varchar(10),
PM_DOB datetime,
PM_DOJ datetime,
PM_Email varchar(10),
PM_Mobile varchar(10),
PM_Location varbinary(10),
PM_Present_address varchar(10000),
PM_Permanent_address varchar(10000),
PM_Acc_No varchar(10),
PM_Tax_No varchar(10),

RM_ID varchar(10),
PM_Status varchar(10),

PRIMARY KEY (PM_ID)
);