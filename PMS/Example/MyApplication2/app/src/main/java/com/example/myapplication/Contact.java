package com.example.myapplication;

public class Contact
{
    private int id;
    private String phone_number;

    public Contact()
    {

    }

    public Contact (int id, String phone_nubmer)
    {
        this.id = id;
        this.phone_number = phone_nubmer;
    }

    public Contact (String phone_nubmer)
    {
        this.phone_number = phone_nubmer;
    }

    public int getId()
    {
        return id;
    }

    public String getPhoneNumber()
    {
        return phone_number;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public void setPhoneNumber(String phone_number)
    {
        this.phone_number = phone_number;
    }
}
