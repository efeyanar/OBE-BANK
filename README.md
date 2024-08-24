Bu uygulama, uygun veritabanının kurulu olmadığı cihazlarda çalışmayacaktır.
Veritabanı için 'banka' isimli bir veritabanı oluşturulmalı içine aşağıdaki script yazılmalıdır.

1- CREATE DATABASE banka

2- create table kullanici_bilgi (
TC varchar(max) not null,
kullanici_adi  varchar(max) not null,
kullanici_soyadi  varchar(max) not null,
kullanici_bakiye money default(0) not null,
kullanici_sifre  varchar(max) not null,
kullanici_uyruk  varchar(max) default('TR') not null,
IBAN int identity(1000,1) ,
kullanici_sube_no  varchar(max) not null,
kullanici_sube  varchar(max) not null 
)
create table kullanici_hesap_haraketleri (
gonderen_kisi varchar(max) not null,
gonder_iban varchar(max) not null,
alan_kisi varchar(max) not null,
alan_iban varchar(max) not null,
gonderilen_miktar varchar(max) ,
aciklama varchar(max) not null,
islem_tarihi varchar(max) not null, )

Ardından uygulama çalışır hale gelecektir.
Başka hesaplara para gönderme kısmında ortak bir veritabanı kurulu olmadığından dolayı sıkıntı çıkabilir bunun için kendi hesabınıza;

update kullanici_bilgi set kullanici_bakiye = 1200(PARA MİKTARI) where TC = 12345678910(HESABA KAYITLI TC KİMLİK NUMARASI)

komutu ile dilediğiniz miktarda para yükleyebilirsiniz.



For English

This app will not work on devices that do not have the appropriate database installed.
A database named 'banka' should be created for the database of the application and the following script should be written into it.

1- CREATE DATABASE banka
2- create table kullanici_bilgi (
TC varchar(max) not null,
kullanici_adi  varchar(max) not null,
kullanici_soyadi  varchar(max) not null,
kullanici_bakiye money default(0) not null,
kullanici_sifre  varchar(max) not null,
kullanici_uyruk  varchar(max) default('TR') not null,
IBAN int identity(1000,1) ,
kullanici_sube_no  varchar(max) not null,
kullanici_sube  varchar(max) not null 
)
create table kullanici_hesap_haraketleri (
gonderen_kisi varchar(max) not null,
gonder_iban varchar(max) not null,
alan_kisi varchar(max) not null,
alan_iban varchar(max) not null,
gonderilen_miktar varchar(max) ,
aciklama varchar(max) not null,
islem_tarihi varchar(max) not null, )

Then the application will become operational.
There may be problems in sending money to other accounts because there is no common database established.

update kullanici_bilgi set kullanici_bakiye = 1200(MONEY AMOUNT) where TC = 12345678910(TR ID NUMBER)

You can upload any amount of money you want with the command.
