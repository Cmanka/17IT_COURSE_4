CREATE OR REPLACE FUNCTION public.get_follower_publications(follower_last_name character varying, follower_first_name character varying, follower_middle_name character varying)
 RETURNS TABLE(publication_name character varying)
 LANGUAGE sql
AS $function$
	select distinct hp."name" 
	from home_subscription hs, home_follower hf , home_follower_subscription hfs , home_release hr , home_publication hp
	where hfs.follower_id = hf.id and 
	hfs.subscription_id = hs.id and 
	hs.release_id = hr.id and 
	hp.id = hr.publication_id and 
	(hf.first_name = follower_first_name and hf.last_name = follower_last_name and hf.middle_name = follower_middle_name);
$function$
;
