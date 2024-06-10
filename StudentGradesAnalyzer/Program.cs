public record StudentGrades(string Name, Dictionary<string, double> Grades);

class Program
{
    static void Main()
    {
        StudentGrades[] students = new StudentGrades[]
        {
            new StudentGrades("Alice", new Dictionary<string, double> { { "Math", 90 }, { "Science", 85 }, { "English", 88 } }),
            new StudentGrades("Bob", new Dictionary<string, double> { { "Math", 80 }, { "Science", 90 }, { "English", 85 } }),
            new StudentGrades("Charlie", new Dictionary<string, double> { { "Math", 95 }, { "Science", 92 }, { "English", 90 } }),
            new StudentGrades("David", new Dictionary<string, double> { { "Math", 70 }, { "Science", 75 }, { "English", 80 } })
        };

        var studentWithMaxAvg = students
            .Select(s => new { s.Name, AverageGrade = s.Grades.Values.Average() })
            .OrderByDescending(s => s.AverageGrade)
            .First();

        Console.WriteLine($"The student with the maximum average grade is {studentWithMaxAvg.Name} with an average grade of {studentWithMaxAvg.AverageGrade:F2}.");
    }
}
