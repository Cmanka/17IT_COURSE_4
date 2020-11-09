-- DROP TRIGGER replace_space_in_description ON public.home_subscription;

create trigger replace_space_in_description after
insert
    or
update
    on
    public.home_subscription for each row execute function example_for_work_with_strings();