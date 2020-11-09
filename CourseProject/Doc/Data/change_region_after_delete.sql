CREATE OR REPLACE FUNCTION public.change_region_after_delete()
 RETURNS trigger
 LANGUAGE plpgsql
AS $function$
	declare 
		new_postman_id int;
		postman_count int;
	begin
	new_postman_id = public."check"(old.id,old.post_office_id);
	postman_count = public.get_employee_count(old.post_office_id);
	if TG_OP = 'DELETE' and old.position_id = 1 then
		if postman_count >= 1 then
			update home_region
			set postman_id = new_postman_id
			where post_office_id = old.post_office_id and postman_id is null;
		else
			raise exception 'cannot delete postmen on region'; 
		end if;
	end if;
	return null;
	END;
$function$
;
