﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class program_3
    {
        public static void Main(string[] args)
        {
            Doctor doctor = new Doctor("Paionia Nongsiej", "22 Mawalai Shillong", 12345, 100.0m, "Cardiology");

        }
    }
}

public class Person
{
    protected string Name;
    protected string Address;

    public Person(string name, string address)
    {
        this.Name = name;
        this.Address = address;
    }
}

public class Doctor : Person
{
    private int RegnNo;
    private decimal FeesCharged;
    private string Specialization;

    public Doctor(string name, string address, int regnNo, decimal feesCharged, string specialization) : base(name, address)
    {
        this.RegnNo = regnNo;
        this.FeesCharged = feesCharged;
        this.Specialization = specialization;
    }
}
