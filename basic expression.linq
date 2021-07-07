<Query Kind="Statements" />

List<int> list = new List<int>(){2,0,1,9,5,3};
var result = from item in list where item >=3 orderby item ascending select item + 2;
foreach(var e in result)
{
	Console.Write(e.ToString() + '\n');
}