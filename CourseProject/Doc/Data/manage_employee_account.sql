CREATE OR REPLACE FUNCTION public.manage_employee_account()
 RETURNS trigger
 LANGUAGE plpgsql
AS $function$
	declare 
		employee_user_name varchar;
		employee_password varchar;
		employee_first_name varchar;
		employee_last_name varchar;
		employee_email varchar;
		employee_is_staff bool;
		employee_is_active bool;
	begin
	if TG_OP = 'INSERT' then
		employee_user_name = ('employee' || new.id);
		employee_password = ('Employee_Pass' || new.id || '*');
		employee_first_name = new.first_name;
		employee_last_name = new.last_name;
		employee_email = new.email;
		employee_is_active = true;
		if new.position_id = 1 then
			employee_is_staff = false;
		else
			employee_is_staff = true;
		end if;
		insert into auth_user (id,username,"password",first_name,last_name,email,is_staff,is_active,is_superuser,date_joined,post_office_id)
		values
		(new.id,employee_user_name,md5(employee_password),employee_first_name,
		employee_last_name,employee_email,employee_is_staff,employee_is_active,false,now(),new.post_office_id);
		insert into auth_user_groups(user_id,group_id)
		values
		(new.id,new.position_id);
	elsif TG_OP = 'DELETE' then
		delete from auth_user_groups aug
		where aug.user_id = old.id;
		delete from auth_user
		where username = ('employee' || old.id);
	end if;
	return null;
	END;
$function$
;
