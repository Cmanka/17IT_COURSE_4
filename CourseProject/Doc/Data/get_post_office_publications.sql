CREATE OR REPLACE FUNCTION public.get_post_office_publications(post_office_name character varying)
 RETURNS TABLE(publ_name character varying, publ_count integer)
 LANGUAGE sql
AS $function$
	select distinct hp2."name" , hr.count 
	from home_postoffice hp, home_release hr , home_publication hp2 
	where hr.publication_id = hp2.id and 
	hr.post_office_id = hp.id and
	hp."name" = post_office_name;
$function$
;
