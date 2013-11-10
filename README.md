Project Specification
The projects goal is to practice querying data in an SQL style format using the Language Integrated Query (LINQ) built into .NET. LINQ provides a fourth generation language style of querying to gather results of our data sets. The project presents a List of 10 employees of a college, all with different attributes that can be used to distinguish how we search. 
  

 
Code/Algorithm Design
	There are three components of this program, three classes, one utility class, a driver class, and an Employee class.

Program
	Program contains just a main method which runs the execution of the project. Its responsibilities are, creating lists of regular employees and bonus employees, populating both lists, querying the lists based on the criteria, and displaying the results. 	

ProgramUtilities
	ProgramUtilities contains the logic for populating the lists of employees, with different level of helper methods.

	PopulateCommonEmployees is handed a reference of an employee list of type List<Employee>, adds five employees to the list, the employees added are always the same five employees. No value is returned.  
	PopulateRandomEmployees is handed a reference of an employee list of type List<Employee>, adds five employees to the lists, the employees added are randomly generated. No value is returned.
	EmployeeGenerator returns a random employee of type Employee. No parameters are expected.
	LevelGenerator returns a level, ‘a’, ‘i’, or ‘s’ of type char. No parameters are expected.
	NameGenerator returns a random first and random last name of type string. No parameters are expected.
	SalaryGenerator returns a random salary of type double. No parameters are expected.
	EmployeeIDGenerator returns a random employee ID of type string. No parameters are expected.
 
Employee
	Employee contains four properties, a four parameter constructor, an enum,  and overridden ToString. Properties include, Name of type string, EmployeeID of type string, Salary of type double, and Level of type Levels. The enumerated type Levels, has three values, Administrator ‘a’, Staff ‘s’, and Instructor ‘i’. The four parameter constructor initializes the values of the parameters to the corresponding properties. The ToString returns a string displaying the four properties. 


 
User Manual
1)	After downloading the sources with the project extract the project into a folder.
2)	After open a command prompt window and navigate (CD command) to the directory …\CSC325_Assignment03\CSC325_Assignment03\bin\Release
3)	Type CSC325_Assignment03.exe and hit enter
4)	At this point the program should begin execution.
5)	The program will display several query results detailed in the requirements.
6)	You have now come to completion of the program included in this project.
