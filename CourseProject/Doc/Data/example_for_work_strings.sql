CREATE OR REPLACE FUNCTION public.example_for_work_with_strings()
 RETURNS trigger
 LANGUAGE plpgsql
AS $function$
	BEGIN
		if TG_OP = 'INSERT' then
			new.description = replace(new.description, E'\xc2\xa0', '');
			return new;
		end if;
	END;
$function$
;
