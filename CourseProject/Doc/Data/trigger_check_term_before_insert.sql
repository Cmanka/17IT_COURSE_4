-- DROP TRIGGER check_term_before_insert ON public.home_subscription;

create trigger check_term_before_insert before
insert
    or
update
    on
    public.home_subscription for each row execute function manage_subscription();