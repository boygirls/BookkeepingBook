use keepbook
go

--撤销权限
revoke connect,create view,insert,update,delete,select to [nt authority\network service]
go

--删除架构
if exists(select * from sys.schemas where name='nt authority\network service')
drop schema [nt authority\network service]
go

--删除用户
if exists(select * from sys.sysusers where name='nt authority\network service')
--或者用if exists(select * from sys.database_principals where name='nt authority\network service')
drop user [nt authority\network service]
go

--切换到系统数据库master
use master
go

--分离你的数据库
if exists(select * from sys.databases where name = 'keepbook')
exec sp_detach_db 'keepbook','true'
go

--删除登录名
if  exists(select * from sys.server_principals where name='nt authority\network service')
drop login [nt authority\network service]
go
