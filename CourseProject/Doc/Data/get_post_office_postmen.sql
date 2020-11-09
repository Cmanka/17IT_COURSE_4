CREATE OR REPLACE FUNCTION public.get_post_office_postmen(post_office_name character varying)
 RETURNS TABLE(last_name character varying, first_name character varying, middle_name character varying)
 LANGUAGE sql
AS $function$
	select he.last_name ,he.first_name ,he.middle_name 
	from home_employee he ,home_postoffice hp , home_position hp2 
	where hp.id = he.post_office_id and
	post_office_name = hp."name" and 
	he.position_id = hp2.id and
	hp2."name" = 'Postman';
$function$
;
