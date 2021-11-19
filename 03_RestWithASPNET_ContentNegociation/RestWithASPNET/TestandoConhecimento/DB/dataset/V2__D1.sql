if not exists(select 1 from books where name = 'book')
insert into books values('teste');