-- DROP TRIGGER loop_trigger ON public.home_postoffice;

create trigger loop_trigger before
insert
    on
    public.home_postoffice for each row execute function example_for_loop_trigger();