CREATE OR REPLACE FUNCTION public.delete_values()
 RETURNS void
 LANGUAGE sql
AS $function$
	delete from home_publication;
	delete from home_publishinghouse;
	delete from home_postoffice;
	delete from home_position;
	delete from home_follower_subscription;
	delete from home_follower;
	delete from home_subscription;
	delete from home_release;
	delete from home_employee;
	delete from home_house;
	delete from home_region;
	delete from auth_user_groups;
$function$
;
