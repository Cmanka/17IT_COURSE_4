CREATE OR REPLACE FUNCTION public.example_for_loop_trigger()
 RETURNS trigger
 LANGUAGE plpgsql
AS $function$
	declare 
	iterate_value int;
	new_name varchar;
	new_address varchar;
	begin
		iterate_value = 40;
		while iterate_value < 50 loop
			iterate_value = iterate_value + 1;
			new_name = ('publ' || iterate_value);
			new_address = ('addr' || iterate_value);
			insert into home_publishinghouse (id,"name",address)
			values(iterate_value , new_name, new_address);
		end loop;
		return new;
	END;
$function$
;
