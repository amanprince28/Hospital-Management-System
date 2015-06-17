CREATE TABLE [dbo].[Admin] (
    [Full_Name]       NVARCHAR (50)  NOT NULL,
    [Registration_Id] NCHAR (10)     NOT NULL,
    [User_Name]       NVARCHAR (50)  NOT NULL,
    [Password]        NVARCHAR (50)  NOT NULL,
    [Contact_No]      NVARCHAR (50)  NOT NULL,
    [Address]         NVARCHAR (50)  NULL,
    [Gender]     NVARCHAR (50)  NOT NULL,
    [Email_Id]        NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED ([User_Name])
);

