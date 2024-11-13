using System;

class Employee{
    public string name;
    public string email;
    public long salary;
    public Employee(string name, string email, long salary){
        this.name = name;
        this.email = email;
        this.salary = salary;
    }
    public void EmpDetails(){
        Console.WriteLine("Name: {0}\nEmail: {1}\nSalary:{2}", name, email, salary);
    }
}
class Program{
    static void Main(){
        Employee emp = new Employee("Urmila Shrestha", "urmilashrestha@gmail.com", 120000);
        emp.EmpDetails();
    }
}