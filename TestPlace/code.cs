using System;
using System.Collections.Generic;
public class MonHoc
{
    public string Name { get; set; }
    public int Id { get; set; }
    public MonHoc(string name, int id)
    {
        Name = name;
        Id = id;
    }
}

public class Nganh
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Nganh(string name, int id)
    {
        Name = name;
        Id = id;
    }
}

public class SinhVien
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Nganh Nganh { get; set; }
    public SinhVien(string name, int id, Nganh nganh)
    {
        Name = name;
        Id = id;
        Nganh = nganh;
    }
}

public class Program
{
    static void Main()
    {
        Nganh economic = new Nganh("Economic", 100);

        SinhVien s1 = new SinhVien("An", 10001, economic);
        SinhVien s2 = new SinhVien("Binh", 10002, economic);
        List<SinhVien> Lop12a2 = new List<SinhVien>();
        Lop12a2.Add(s1);
        Lop12a2.Add(s2);
        foreach (var item in Lop12a2)
        {
            Console.WriteLine($"Ten: {item.Name} | Nganh: {item.Nganh.Name}");
        }
    }
}