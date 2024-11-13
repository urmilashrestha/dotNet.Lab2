using System;

class Movie{
    public virtual void BestMovie(){
        Console.WriteLine("Dunkirk");
    }
}

class Cinema:Movie{
    public override void BestMovie(){
        Console.WriteLine("Chennai Express");
    }
}

class Program{
    static void Main(){
        Cinema c = new Cinema();
        c.BestMovie();
    }
}
