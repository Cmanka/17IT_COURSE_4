CREATE OR REPLACE FUNCTION public.get_employee_count(emp_post_office_id integer)
 RETURNS bigint
 LANGUAGE sql
AS $function$
	select count(*) from home_employee he
	where he.post_office_id = emp_post_office_id and he.position_id = 1;
$function$
;
