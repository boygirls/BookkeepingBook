use keepbook
go

--����Ȩ��
revoke connect,create view,insert,update,delete,select to [nt authority\network service]
go

--ɾ���ܹ�
if exists(select * from sys.schemas where name='nt authority\network service')
drop schema [nt authority\network service]
go

--ɾ���û�
if exists(select * from sys.sysusers where name='nt authority\network service')
--������if exists(select * from sys.database_principals where name='nt authority\network service')
drop user [nt authority\network service]
go

--�л���ϵͳ���ݿ�master
use master
go

--����������ݿ�
if exists(select * from sys.databases where name = 'keepbook')
exec sp_detach_db 'keepbook','true'
go

--ɾ����¼��
if  exists(select * from sys.server_principals where name='nt authority\network service')
drop login [nt authority\network service]
go
