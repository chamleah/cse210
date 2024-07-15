using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("Leah Chamberlain, "Ammon", "ID", "83406", "USA");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Stake Conference", "Church meeting with members of the Thunder Ridge Stake.", "July 8, 2024", "10:00 am - 12:00 pm", $"{lectureAddress}", "Lecture", "Elder Hall", 400);

        //display lecture event details
        Console.WriteLine("---------------------------------------------------------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();


        Address address2 = new Address ("Caden Murdock", "Idaho Falls", "ID", "83406", "USA");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Ethan and Courtney", "Ethan and Courtney's wedding ceremony and reception", "October 22, 2024", "4:00 pm - 12:00am", $"{receptionAddress}", "Reception", "murdock@gmail.com");
        //display reception event details
        Console.WriteLine("---------------------------------------------------------------------------");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


        Address address3 = new Address ("4800 majestic view drive", "Ammon", "ID", "83406", "USA");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Youth Activity", "Swimming night at the pool for all youth.", "August 12, 2024", "6:00 pm", $"{outdoorAddress}", "Outdoor", "Sunny");
        //display outdoor event details
        Console.WriteLine("---------------------------------------------------------------------------");
        
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine("---------------------------------------------------------------------------");
        
    }
}