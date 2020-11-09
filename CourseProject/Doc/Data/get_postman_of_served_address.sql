CREATE OR REPLACE FUNCTION public.get_postman_of_served_address(address_name character varying)
 RETURNS TABLE(last_name character varying, first_name character varying, middle_name character varying)
 LANGUAGE sql
AS $function$
	select he.last_name , he.first_name , he.middle_name 
	from home_employee he ,home_region hr, home_house hh 
	where hh.region_id = hr.id and 
	he.id = hr.postman_id and 
	hh.address = address_name;
$function$
;
