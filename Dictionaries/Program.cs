

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not a human";
lookup["fish"] = "Not a human that swims.";
lookup["human"] = "US";

Console.WriteLine($"The definition of fish is {lookup["fish"]}");


Dictionary<int, string> employees = new Dictionary<int, string>();

employees[95] = "Tim Corey";
employees[28] = "Sue Storm";

Console.WriteLine($"The employee with ID 28 is {employees[28]}");


Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Sunday"] = 1;
dayOfWeek["Monday"] = 2;
dayOfWeek["Tuesday"] = 3;
dayOfWeek["Wednesday"] = 4;
dayOfWeek["Thursday"] = 5;
dayOfWeek["Friday"] = 6;
dayOfWeek["Saturday"] = 7;

Console.WriteLine($"Wednesday is day number {dayOfWeek["Wednesday"]}");