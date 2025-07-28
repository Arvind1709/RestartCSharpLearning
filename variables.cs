namespace RestartCSharpLearning
{
    internal class Variables
    {
        public readonly string UniqueID = "STU1024"; // readonly
        public static string SchoolName = "The Bright Future School"; // static
        // 1. Class-level variable
        string name = "Arvind";

        // 2. Static variable
        static string company = "TechSoft Pvt Ltd";

        // 3. Const variable
        const double Pi = 3.14159;

        // 4. Readonly variable
        readonly string empId;

        // 5. Array (Reference type)
        int[] projectHours = { 8, 9, 7, 6, 8 };
        public Variables()
        {
            // Initialize readonly variable in constructor
            empId = "EMP12345";
        }
        public void Example()
        {
            // Integer - whole number
            int age = 25;

            // Double - decimal number
            double height = 5.9;

            // Float - smaller decimal (must add 'f')
            float weight = 62.5f;

            // Decimal - high precision decimal (must add 'm')
            decimal salary = 45000.75m;

            // Character
            char grade = 'A';

            // String - group of characters
            string name = "Arvind";

            // Boolean - true or false
            bool isEmployed = true;

            // var - compiler infers the type
            var city = "Delhi";   // string
            var score = 98.6;     // double

            // Constant - value cannot be changed
            const double Pi = 3.14159;

            // Display all values
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Is Employed: " + isEmployed);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Pi (constant): " + Pi);
        }
        public void Details()
        {
            // Personal Info
            string name = "Arvind";
            int age = 25;
            char gender = 'M';
            bool isStudent = true;
            const string country = "India";

            // Marks
            float mathMarks = 85.5f;
            float scienceMarks = 78.0f;
            float englishMarks = 90.0f;

            // Calculations
            var totalMarks = mathMarks + scienceMarks + englishMarks;
            var averageMarks = totalMarks / 3;

            // Display Output
            Variables s = new Variables();

            Console.WriteLine("=== Student Details ===");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Is Student: " + isStudent);
            Console.WriteLine("Country: " + country);
            Console.WriteLine("School: " + SchoolName);
            Console.WriteLine("Unique ID: " + s.UniqueID);

            Console.WriteLine();
            Console.WriteLine("Math Marks: " + mathMarks);
            Console.WriteLine("Science Marks: " + scienceMarks);
            Console.WriteLine("English Marks: " + englishMarks);
            Console.WriteLine();
            Console.WriteLine("Total Marks: " + totalMarks);
            Console.WriteLine("Average Marks: " + averageMarks);
        }

        public void Information()
        {
            // 6. Local variable (Value type)
            int age = 30;

            // 7. Implicitly typed
            var salary = 85000.50m;

            // 8. Nullable type
            int? bonus = null;

            // 9. Dynamic type
            dynamic today = DateTime.Now;
            today = "Friday"; // Allowed due to dynamic

            // Object to access non-static members
            Variables p = new Variables();

            // Output everything
            Console.WriteLine("=== Employee Details ===");
            Console.WriteLine($"Name        : {p.name}");
            Console.WriteLine($"Age         : {age}");
            Console.WriteLine($"Emp ID      : {p.empId}");
            Console.WriteLine($"Company     : {company}");
            Console.WriteLine($"Salary      : {salary}");
            Console.WriteLine($"Bonus       : {(bonus.HasValue ? bonus.ToString() : "No Bonus")}");
            Console.WriteLine($"Today is    : {today}");
            Console.WriteLine($"Pi Constant : {Pi}");

            // Array usage
            Console.WriteLine("\n--- Project Hours This Week ---");
            int totalHours = 0;
            foreach (var hrs in p.projectHours)
            {
                Console.WriteLine($"Day: {hrs} hrs");
                totalHours += hrs;
            }

            Console.WriteLine($"Total Hours: {totalHours}");
        }
    }
}
