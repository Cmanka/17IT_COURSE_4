package com.example.domain;

public class Employee {
    public int empId;
    public String name;
    public String ssn;
    public double salary;


    public Employee(){}


    public int getEmpId() {
        return empId;
    }

    public String getName() {
        return name;
    }

    public String getSsn() {
        return ssn;
    }

    public double getSalary() {
        return salary;
    }

    public void setEmpId(int empId) {
        this.empId = empId;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setSsn(String ssn) {
        this.ssn = ssn;
    }

    public void setSalary(double salary) {
        this.salary = salary;
    }
}
