using System;

class Student{
    private int std_id = 100;
    private string name;
    //read only property
    public int Std_id{
        get{ return std_id; }
    }
    //write only property
    public string Name{
        set{ name = value; }
    }
    public void PrintDetails(){
        Console.WriteLine("ID: {0}\nName: {1}", std_id, name);
    }
}

class Program{
    static void Main(){
        Student std = new Student();
        //using read only property
        Console.WriteLine(std.Std_id);
        //using write only property
        std.Name = "Urmila";
        std.PrintDetails();
    }
}
