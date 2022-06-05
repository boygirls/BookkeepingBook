use master
go

--����[nt authority\network service]ΪSQLʵ����¼��
if not exists(select * from sys.server_principals where name='nt authority\network service')
--drop login [nt authority\network service]
--go
create login [nt authority\network service] from windows with default_database=master
go

--����������ݿ⵽��SQLʵ��
if exists(select * from sys.databases where name='keepbook')
exec sp_detach_db 'keepbook','true'
go

-- ���Լ�ʹ��ʱӦ��Ϊ�Լ������ݿ��ַ
create database keepbook
on (filename='D:\Huawei\HUAWEICloudContent\��Ϊ����\code\net\BookkeepingBook\SQL\keepbook.mdf'),
(filename='D:\Huawei\HUAWEICloudContent\��Ϊ����\code\net\BookkeepingBook\SQL\keepbook_log.ldf')
for attach
go

--�л���������ݿ�
use keepbook
go

--�������ݿ��û���ע�⣺SQL2005�����ϰ汾��ͬʱҲ�����˼ܹ���
if not exists(select name from sys.sysusers where name='nt authority\network service')
create user [nt authority\network service] 
for login [nt authority\network service]
go

--�����û�����Ȩ��
grant connect,create view,insert,update,delete,select
to [nt authority\network service]
go

