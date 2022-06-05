use master
go

--创建[nt authority\network service]为SQL实例登录名
if not exists(select * from sys.server_principals where name='nt authority\network service')
--drop login [nt authority\network service]
--go
create login [nt authority\network service] from windows with default_database=master
go

--附加你的数据库到该SQL实例
if exists(select * from sys.databases where name='keepbook')
exec sp_detach_db 'keepbook','true'
go

-- 到自己使用时应改为自己的数据库地址
create database keepbook
on (filename='D:\Huawei\HUAWEICloudContent\华为云盘\code\net\BookkeepingBook\SQL\keepbook.mdf'),
(filename='D:\Huawei\HUAWEICloudContent\华为云盘\code\net\BookkeepingBook\SQL\keepbook_log.ldf')
for attach
go

--切换到你的数据库
use keepbook
go

--创建数据库用户（注意：SQL2005及以上版本，同时也创建了架构）
if not exists(select name from sys.sysusers where name='nt authority\network service')
create user [nt authority\network service] 
for login [nt authority\network service]
go

--授予用户常用权限
grant connect,create view,insert,update,delete,select
to [nt authority\network service]
go

