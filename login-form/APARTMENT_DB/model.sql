CREATE TABLE [dbo].[APARTMENT_DETAILS] (
    [APARTMENT_NAME]     VARCHAR (50) NULL,
    [APARTMENT_NO]       INT          NOT NULL,
    [APARTMENT_SIZE]     INT          NOT NULL,
    [APARTMENT_PRICE]    INT          NOT NULL,
    [APARTMENT_LOCATION] VARCHAR (50) NOT NULL,
    [APARTMENT_PICTURE]  IMAGE        NOT NULL,
    [CUSTOMER_ID]        INT          NULL,
    [STATUS]             VARCHAR (50) NULL
);

GO
CREATE TABLE [dbo].[BILL_DETAILS] (
    [APARTMENT_PRICE] INT          NULL,
    [EXTRA_COST]      INT          NULL,
    [APARTMENT_NO]    INT          NULL,
    [BILL_NO]         VARCHAR (50) NULL,
    [TOTAL_BILL]      INT          NULL,
    [ADVANCE_PAID]    INT          NULL,
    [CUSTOMER_NAME]   VARCHAR (50) NULL,
    [TOTAL_ASSET]     INT          NULL
);

GO
CREATE TABLE [dbo].[CUSTOMER_DETAILS] (
    [CUSTOMER_ID]      INT          NOT NULL,
    [CUSTOMER_NAME]    VARCHAR (50) NULL,
    [APARTMENT_NO]     INT          NOT NULL,
    [PHONE]            VARCHAR (50) NOT NULL,
    [NID]              INT          NOT NULL,
    [CUSTOMER_PICTURE] IMAGE        NOT NULL
);

GO
CREATE TABLE [dbo].[INCOME_DETAILS] (
    [ASSESTS]    INT NULL,
    [DUE]        INT NULL,
    [TOTAL_SELL] INT NULL
);

GO
CREATE TABLE [dbo].[MANAGER_DETAILS] (
    [MANAGER_ID]   INT          NOT NULL,
    [MANAGER_NAME] VARCHAR (50) NOT NULL,
    [ADDRESS]      VARCHAR (50) NOT NULL,
    [PHONE_NO]     INT          NOT NULL,
    [JOINING_DATE] VARCHAR (50) NOT NULL,
    [NID]          VARCHAR (50) NOT NULL,
    [SALARY]       INT          NOT NULL
);

GO
CREATE TABLE [dbo].[STAFF_DETAILS] (
    [STAFF_ID]   INT          NOT NULL,
    [STAFF_NAME] VARCHAR (50) NOT NULL,
    [PHONE]      INT          NOT NULL,
    [ADDRESS]    VARCHAR (50) NOT NULL,
    [JOINING]    VARCHAR (50) NOT NULL,
    [NID]        INT          NOT NULL,
    [POST]       VARCHAR (50) NOT NULL,
    [SALARY]     INT          NOT NULL
);

GO
ALTER TABLE [dbo].[APARTMENT_DETAILS]
    ADD CONSTRAINT [PK__APARTMEN__11D5D6F5FE2BC634] PRIMARY KEY CLUSTERED ([APARTMENT_NO] ASC);

GO
