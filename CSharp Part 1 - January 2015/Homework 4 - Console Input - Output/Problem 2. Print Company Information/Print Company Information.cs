using System;

class printCompanyInformation
{
    /* A company has name, address, phone number, fax number, web site and manager. 
     * The manager has first name, last name, age and a phone number.
     * Write a program that reads the information about a company and its manager 
     * and prints it back on the console. */
    static void Main()
    {
        Console.Write("Enter the name of the company: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter the address of the company: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter the company's phone number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Enter the company's fax number: ");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Enter the company's web site: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Enter the manager's first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Enter the manager's last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Enter the manager's age: ");
        string ageStr = Console.ReadLine();
        int managerAge;
        int.TryParse(ageStr, out managerAge);

        Console.Write("Enter the manager's phone number: ");
        string managerPhoneNumber = Console.ReadLine();


        Console.WriteLine("Company name: {0}", companyName != "" ? companyName : "no name");
        Console.WriteLine("Company address: {0}", companyAddress != "" ? companyAddress : "no address");
        Console.WriteLine("Company phone number: {0}", companyPhoneNumber != "" ? companyPhoneNumber : "no number");
        Console.WriteLine("Company fax number: {0}", companyFaxNumber != "" ? companyFaxNumber : "no fax");
        Console.WriteLine("Company web site: {0}", companyWebSite != "" ? companyWebSite : "no web site");
        Console.WriteLine("Manager's first name: {0}, Manager's last name: {1}, Manager's age: {2}, Manager's phone number: {3}", 
            managerFirstName != "" ? managerFirstName : "no name",
            managerLastName != "" ? managerLastName : "no name",
            managerAge,
            managerPhoneNumber != "" ? managerPhoneNumber : "no phone number");
    }
}