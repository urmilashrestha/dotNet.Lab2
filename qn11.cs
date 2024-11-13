using System;

class DataStore<T>{
    private T[] data = new T[5];
    public void AddOrUpdate(int index, T item){
        if(index >= 0 && index < 5){
            data[index] = item;
        }
    }
    public T GetData(int index){
        if(index >= 0 && index < 5){
            return data[index];
        }else{
            return default(T);
        }
    }
}

class Program{
    static void Main(){
        DataStore<string> d = new DataStore<string>();
        d.AddOrUpdate(0, "Urmila");
        d.AddOrUpdate(1, "Babi");
        d.AddOrUpdate(2, "Erika");
        d.AddOrUpdate(3, "Rita");
        Console.WriteLine(d.GetData(0));
        Console.WriteLine(d.GetData(2));
    }
}


