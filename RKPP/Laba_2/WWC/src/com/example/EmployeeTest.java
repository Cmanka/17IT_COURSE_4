package com.example;
import com.example.domain.Employee;

public class EmployeeTest {

    public static void main(String[] args) {
        Employee emp = new Employee();
        emp.setEmpId(1);
        emp.setName("Andrey");
        emp.setSalary(120.120);
        emp.setSsn("013-541-432");
        System.out.println("Employee Id:"+emp.getEmpId());
        System.out.println("Employee name:"+emp.getName());
        System.out.println("Employee soc sec:"+emp.getSsn());
        System.out.println("Employee salary:"+emp.getSalary());
    }
}
