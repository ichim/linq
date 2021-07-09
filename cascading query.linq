<Query Kind="Statements" />

List<Department> departaments = new List<Department>() {
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



var result = from dept in departaments 
where (from empl in employees where empl.number_of_employees >= 20 select empl.id).Contains(dept.id) 
select dept;
result.Dump("Depts");


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