CREATE OR REPLACE FUNCTION public.is_on_post_office(subscription_id integer)
 RETURNS boolean
 LANGUAGE sql
AS $function$
	select case when exists(
		select *
		from home_follower_subscription hfs, home_postoffice hp , home_release hr,home_subscription hs 
		where hfs.subscription_id = subscription_id and 
		hfs.subscription_id = hs.id and 
		hs.release_id = hr.id and 
		hp.id = hr.publication_id
	)
	then cast(1 as bool)
	else cast(0 as bool) end;
$function$
;
