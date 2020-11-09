-- DROP TRIGGER delete_emp_and_acc ON public.home_employee;

create trigger delete_emp_and_acc after
delete
    on
    public.home_employee for each row execute function manage_employee_account();