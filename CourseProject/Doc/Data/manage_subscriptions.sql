CREATE OR REPLACE FUNCTION public.manage_subscription()
 RETURNS trigger
 LANGUAGE plpgsql
AS $function$
	declare 
		term_sub int;
	begin
	if TG_OP = 'INSERT' then
		term_sub = new.term;
		if term_sub <= 0 then
			raise exception 'Term cannot be 0 or less';
		else
			return new;
		end if;
	end if;
	return null;
	END;
$function$
;
