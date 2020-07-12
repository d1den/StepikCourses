use store;
select * from client;
select * from sale;
select * from status;

select count(1), client_id from sale group by client_id order by client_id;

select c.first_name, c.last_name, count(1) from client as c
inner join sale as s on c.id = s.client_id
inner join status as st on s.status_id = st.id where st.name = 'new'  group by s.client_id;

select g.name as good_name, c.name as categ from good as g
left outer join category_has_good as cg on g.id = cg.good_id
left outer join category as c on cg.category_id = c.id
union 
select g.name as good_name, c.name as categ from good as g
right outer join category_has_good as cg on g.id = cg.good_id
right outer join category as c on cg.category_id = c.id;

select s.name, sum(sl.sale_sum) from source as s
left outer join client as c on s.id = c.source_id
left outer join sale as sl on c.id = sl.client_id
group by s.name;

select g.name from good as g
inner join category_has_good as cg on g.id = cg.good_id
inner join category as c on cg.category_id = c.id
where c.name = 'Cakes'
union
select g.name from good as g
inner join sale_has_good as sg on g.id = sg.good_id
inner join sale as s on sg.sale_id = s.id
inner join status as st on s.status_id = st.id
where st.name = 'delivering';

select c.name, count(s.id) from category as c
left outer join category_has_good as cg on c.id = cg.category_id
left outer join good as g on cg.good_id = g.id
left outer join sale_has_good as sg on g.id = sg.good_id
left outer join sale as s on sg.sale_id = s.id
group by c.name;

select * from source as s
left outer join client as c on s.id = c.source_id;

select * from source as s
left outer join client as c on s.id = c.source_id
left outer join sale as sl on c.id = sl.client_id;

select * from source as s
left outer join client as c on s.id = c.source_id
left outer join sale as sl on c.id = sl.client_id
left outer join status as st on sl.status_id = st.id;

select s.name from source as s
left outer join client as c on s.id = c.source_id
where c.source_id is null
union
select s.name from source as s
left outer join client as c on s.id = c.source_id
left outer join sale as sl on c.id = sl.client_id
where sl.client_id is null
union
select s.name from source as s
inner join client as c on s.id = c.source_id
inner join sale as sl on c.id = sl.client_id
inner join status as st on sl.status_id = st.id
where st.name = 'rejected';