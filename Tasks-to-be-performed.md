# C Sharp Grade Book Application

The C Sharp Grade Book Application is a designed to allow instructors to create gradebooks, add students to those grade books, add grades to those students, and calculate statics such as GPA (Grade Point Average).

## Accepted Commands

### Commands when no gradebooks are open

- "Create `Name of Gradebook` `Is this Gradebook Weighted (true/false)`" : Creates a new gradebook with the provided name
- "Help" : gives you a list of all valid commands within the given context
- "Load `Name of GradeBook`"
- "Quit" : Closes the application

### Commands when a gradebook is open

- "Add `Name of Student` `Type of Student` `Type of Enrollment`" : Adds a new student to the open gradebook
- "Remove `Name of Student`" : Removes a student with the provided name from the gradebook, if a student with that name exists in the gradebook
- "List" : Lists all students in the open gradebook
- "AddGrade `Name of Student` `Score`" : Adds to the given value to provided student's grades
- "RemoveGrade `Name of Student` `Score`" : Removes the given value from the provided student's grade, if that value exists in the student's grades
- "Statistics all" : Provides statistical output for all students in the open gradebook
- "Statistics `Name of Student`" : Provides statistical out put for the provided student, if that student exists
- "Help" : Gives you a list of all valid commands within the given context
- "Save" : Saves the open gradebook
- "Close" : Closes the gradebook

# Setup the Application

## If you want to use Visual Studio

If you want to use Visual Studio (highly recommended) follow these steps:

- If you already have Visual Studio installed make sure you have .Net Core installed by running the "Visual Studio Installer" and making sure ".NET Core cross-platform development" is checked
- If you need to install Visual Studio, download it at <https://www.microsoft.com/net/download/>
  - If you're using Windows you'll want to check ".NET Core cross-platform development" on the workloads screen during installation
- Open the `GradeBook.sln` file in Visual Studio
- To run the application simply press the Start Debug button (green arrow) or press F5
- If you're using Visual Studio on Windows, to run tests open the Test menu, click Run, then click on Run all tests (results will show up in the Test Explorer)
- If you're using Visual Studio on macOS, to run tests, select the GradeBookTests Project, then go to the Run menu, then click on Run Unit Tests (results will show up in the Unit Tests panel)

(Note: All tests should fail at this point; this is by design. As you progress through the projects more and more tests will pass. All tests should pass upon completion of the project.)

## If you don't plan to use Visual studio

If you would rather use something other than Visual Studio

- Install the .Net Core SDK from <https://www.microsoft.com/net/download/core>. Once that installation completes you're ready to roll!
- To run the application go into the GradeBook project folder and type `dotnet run`
- To run the tests go into the GradeBookTests project folder and type `dotnet test`

# Features you will implement

- Add support for Ranked Grading
- Add support for Weighted GPAs

## Tasks necessary to complete implementation

__Note:__ This isn't the only way to accomplish implementation, however; this is what the project's tests are expecting. Implementing the features in a different way will likely result in being marked as incomplete / incorrect.

- [ ] Add support for Ranked Grading
	- [x] Creating The `GradeBookType` Enum.
		- [x] Create a new Enum `GradeBookType`.
			- This should be located in the `Enums` directory.
			- This should use the `GradeBooks.Enums` namespace.
			- This should use the `public` access modifier.
			- This should contain the values `Standard`, `Ranked`, `ESNU`, `OneToFour`, and `SixPoint`.

	- [x] Add `Type` property
		- [x] Add a new property `Type` to `BaseGradeBook`
			- This should use the name `Type`.
			- This should be of type `GradeBookType`.
			- This should use the `public` access modifier.

	- [x] Creating the `StandardGradeBook` class
		- [x] Create a class `StandardGradeBook` _(Once this change is made the code will not compile until completion of the next task)_
			- This should be located in the `GradeBooks` directory.
			- This should use the `GradeBook.GradeBooks` namespace.
			- This should inherit the `BaseGradeBook` class.
		- [x] Create a constructor for `StandardGradeBook`
			- This should accept a parameter `name` of type `string`.
			- This should set `Type` to `GradeBookType.Standard`.
			- This should call the `BaseGradeBook` constructor by putting ` : base(name)` after the constructor declaration. _(This was not covered in the course, it calls the constructor of the inherited class.)_

	- [ ] Creating the `RankedGradeBook` class
		-  [ ] Create a class `RankedGradeBook` _(Once this change is made the code will not compile until completion of the next task)_
			- This should be located in the `GradeBooks` directory.
			- This should use the `GradeBook.GradeBooks` namespace.
			- This should inherit the `BaseGradeBook` class.
		-  [ ] Create a constructor for `RankedGradeBook`
			- This should accept a parameter `name` of type `string`.
			- This should set `Type` to `GradeBookType.Ranked`.
			- This should call the `BaseGradeBook` constructor by putting ` : base(name)` after the constructor declaration. _(This was not covered in the course, it calls the constructor of the inherited class.)_

	- [ ] Override `RankedGradeBook`'s `GetLetterGrade` method
		- [ ] Provide the appropriate grades based on how the input grade compares to other students.
			_(One way to solve this is to figure out how many students make up 20%, then loop through all the grades and check how many scored higher than the input average, every N students where N is that 20% value drop a letter grade.)_
			- If there are less than 5 students throw an `InvalidOperationException`.
			- Return A if the input grade is in the top 20% of the class.
			- Return B if the input grade is between the top 20 and 40% of the class.
			- Return C if the input grade is between the top 40 and 60% of the class.
			- Return D if the input grade is between the top 60 and 80% of the class.
			- Return F if the grade is below the top 80% of the class.

	- [ ] Override `RankedGradeBook`'s `CalculateStatistics` method
		- [ ] Short circuit the method if there are less than 5 students.
			- If there are less than 5 students write "Ranked grading requires at least 5 students." to the Console.
			- If there are 5 or more students call the base class's `CalculateStatistics` method using `base.CalculateStatistics`.

	- [ ] Override `RankedGradeBook`'s `CalculateStudentStatistics` method
		- [ ] Short circuit the method if there are less than 5 students.
			- If there are less than 5 students write "Ranked grading requires at least 5 students." to the Console.
			- If there are 5 or more students call the base class's `CalculateStudentStatistics` method using `base.CalculateStudentStatistics`.

	- [ ] Update `StartingUserInterface`'s `CreateCommand` method
		- [ ] Update `CreateCommand`'s Conditions
			- When checking the `parts.Length` it should check that `parts.Length` is not 3.
			- If `parts.Length` is not 3 write "Command not valid, Create requires a name and type of gradebook." to the Console.
		- [ ] return a new GradeBook based on the provided type
			- If the value of `parts[2]` is "standard" return a newly instantiated `StandardGradeBook` using the `name` variable.
			- If the value of `parts[2]` is "ranked" return a newly instantiated `RankedGradeBook` using the `name` variable.
			- If the value of `parts[2]` doesn't match the above write the value of `parts[2]` followed by " is not a supported type of gradebook, please try again" to the console, then escape the method.

	- [ ] Update `StartingUserInterfaces`'s `HelpCommand` method
		- [ ] Change where `HelpCommand` outlines the "create" command to write "Create 'Name' 'Type' - Creates a new gradebook where 'Name' is the name of the gradebook and 'Type' is what type of grading it should use." to the console.

	- [ ] Make the `BaseGradeBook` class abstract
		- [ ] Add the `abstract` keyword to the `BaseGradeBook` declaration.

- [ ] Add support for weighted GPAs
	- [ ] Add `IsWeighted` property to `BaseGradeBook`
		- [ ] Create a new `bool` property named `IsWeighted` in `BaseGradeBook`
			- This should use the public access modifier.
			- This should be of type `bool`.
			- This should be named `IsWeighted`.

	- [ ] Refactor constructor of `BaseGradeBook`
		_Note, once this group of tasks is begun the code will not compile until the entire group of tasks is complete._
		- [ ] Add a `bool` to the `BaseGradeBook` constructor
			- This should be of type `bool`.
			- This should be the second parameter.
		- [ ] Set `IsWeight` in the `BaseGradeBook` constructor
			- [ ] Set the `IsWeighted` property using the `bool` parameter
		- [ ] Add a `bool` to the `StandardGradeBook` constructor
			- This should be of type `bool`.
			- This should be the second parameter.
			- This will require the bool to be added to the call to the base constructor.
		- [ ] Add a `bool` to the `RankedGradeBook` constructor
			- This should be of type `bool`.
			- This should be the second parameter.
			- This will require the bool to be added to the call to the base constructor.
		- [ ] Update `StartingUserInterface.CreateCommand` condition
			- Change the condition checking if `parts` is not equal to 3 to be is not equal to 4.
		- [ ] Update `StartingUserInterface.CreateCommand` to accept `IsWeighted`
			- This should use `parts[3]` for the last parameter where the gradebooks are instantiated.
			- Update the message provided by this condition to write to the console "Command not valid, Create requires a name, type of gradebook, if it's weighted (true / false).".

	- [ ] Update `BaseGradeBook.GetGPA`
		- [ ] Add 1 point to GPA when student is `Honors` or `DualEnrolled`

	- [ ] Update `HelpCommand`
		- [ ] Change where the `HelpCommand` outlines the "create" command to say "Create 'Name' 'Type' 'Weighted' - Creates a new gradebook where 'Name' is the name of the gradebook, 'Type' is what type of grading it should use, and 'Weighted' is whether or not grades should be weighted (true or false)."

## What Now?

You've completed the tasks of this project, if you want to continue working on this project some next steps would be to add support for some of the other grading formats, set Save to run automatically when Adding/Removing students and grades, etc.

Otherwise now is a good time to continue on the C# path to expand your understanding of the C# programming language or start looking into the User Interface options of C# whether that's ASP.NET (web), XAML (applications), DirectX (graphically intense applications), etc
