using System.Text;

public class Student : Human
{
    private string facultyNumber;

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            if (value.Length<5 || value.Length>10)
            {
                throw new System.ArgumentException("Invalid faculty number!");
            }
            foreach (var letter in value)
            {
                if (!char.IsLetterOrDigit(letter))
                {
                    throw new System.ArgumentException("Invalid faculty number!");
                }
            }
            facultyNumber = value;
        }
    }

    public Student(string studentFirstName, string studentLastName, string studentFacultyNumber)
        : base(studentFirstName,studentLastName)
    {
        FacultyNumber = studentFacultyNumber;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {FirstName}");
        sb.AppendLine($"Last Name: {LastName}");
        sb.AppendLine($"Faculty number: {facultyNumber}");
        
        var result = sb.ToString().TrimEnd();
        return result;
    }
}