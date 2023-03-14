using System;

public class CustomerAccount
{
    string bank_name;
    long accountNo;
    string customer_Name;
    public CustomerAccount(long acc_no, string cust_Name)
    {

        customer_Name = cust_Name;
        accountNo = acc_no;
        bank_name = "Simform Bank Pvt Ltd";


    }

    /// <summary>
    /// It's display accountNo, customer_Name, bank_name
    /// </summary>
    /// <returns>
    /// void 
    /// </returns>
    public void PrintInfo()
    {

        Console.WriteLine($"Customer Name:- {customer_Name} \nAccount No:- {accountNo}\nBank Name;- {bank_name}");

    }

    public static void Main()
    {


        Console.WriteLine("------------------------SIMFORM BANK PVT LTD------------------------");
        CustomerAccount ca = new CustomerAccount(13032023,"Jayesh Bellani");
        ca.PrintInfo(); 



    }


}