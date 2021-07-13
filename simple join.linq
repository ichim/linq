<Query Kind="Statements" />

List<Department> departments = new List<Department>() {
	new Department(){
		name = "Hydro",
		id = 100
		},
	new Department(){
		name = "Mechanics",
		id = 101
		},
	new Department(){
		name = "Financial",
		id = 102
		},
	new Department(){
		name = "Administrative",
		id = 103
		},
	new Department(){
		name = "Maintenance",
		id = 104
		}
};
List<Employees> employees = new List<Employees>() {
	new Employees(){
		number_of_employees = 38,
		id = 100
		},
	new Employees(){
		number_of_employees = 27,
		id = 101
		},
	new Employees(){
		number_of_employees = 12,
		id = 102
		},
	new Employees(){
		number_of_employees = 9,
		id = 103
		},
	new Employees(){
		number_of_employees = 21,
		id = 104
		}
};

var results = from dept in departments 
			 join emp in employees 
			 on dept.id equals emp.id 
			 select new Report(){
								department = dept.name,
								number_of_employees = emp.number_of_employees
								 };
results.Dump();


public class Report
{
	public string department {get;set;}
	public int number_of_employees {get;set;}
}

public class Department
{
	public string name {get;set;}
	public int id {get;set;}
}

public class Employees
{
	public int id {get;set;}
	public int number_of_employees {get;set;}
}
