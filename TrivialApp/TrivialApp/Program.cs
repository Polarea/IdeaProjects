﻿public class Employee
{
	public int Id { get; set; }
	public double Salary { get; set; }
	public string Name { get; set; }
	public Employee (int id, double salary, string name)
	{
		Id = id;
		Salary = salary;
		Name = name;
	}
	public object this[int Index]
	{
		get
		{
			if (Index == 0)
				return Id;
			else if (Index == 1)
				return Salary;
			else if (Index == 2)
				return Name;
			else
			return null;
		}
	}
}

class TestEmployee
{
	static void Main()
	{
		Employee emp = new Employee(1001, 50000, "John");
		Console.WriteLine($"Employee's name is {emp[2]}, Id is {emp[0]} and salary is {emp[1]}.");
	}
}



