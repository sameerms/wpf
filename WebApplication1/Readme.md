## legger in product table 

CREATE TABLE [dbo].[Produts](
[ProductId][int] IDENTITY(1,1) NOT NULL,
[NAME][nvarchar](max) NULL,
[Quantity][int] NULL,
[Price][float] NULL,
CONSTRAINT [PK_PRoducts] PRIMARY KEY CLUSTERED
(
[ProductId] ASC
) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE= OFF, IGNORE_DUP_KEY= OFF, ALLOW_ROW_LOCKS= OFF, ALLOW_PAGE_LOCKS= ON
)ON [PRIMARY]) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


## global.asax swagger integration with nswag and owin

https://github.com/RicoSuter/NSwag/wiki/OwinGlobalAsax#integration