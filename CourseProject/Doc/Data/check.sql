CREATE OR REPLACE FUNCTION public."check"(old_employee_id integer, old_post_office_id integer)
 RETURNS integer
 LANGUAGE sql
AS $function$
		select id 
		from home_employee he 
		where he.post_office_id = old_post_office_id and he.id != old_employee_id;
$function$
;
