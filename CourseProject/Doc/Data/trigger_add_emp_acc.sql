-- DROP TRIGGER add_emp_and_acc ON public.home_employee;

create trigger add_emp_and_acc after
insert
    on
    public.home_employee for each row execute function manage_employee_account();