create PROCEDURE insert_kullanici

(

    @kodu NVARCHAR(20),
	@sifre NVARCHAR(20),  
	@yetki NVARCHAR(5),
	@unvan NVARCHAR(15),
	@isebaslama DATETIME,
	@tckimlikno NVARCHAR(11),
	@username NVARCHAR(50)    

)

AS

BEGIN

    SET NOCOUNT ON;
    insert into SOHATS.dbo.kullanici(kodu,sifre,yetki,unvan,isebaslama,tckimlikno,username) values(@kodu,@sifre,@yetki,@unvan,@isebaslama,@tckimlikno,@username)  

    

END