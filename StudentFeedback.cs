using System.ComponentModel.DataAnnotations;

namespace InstructorFormCreation
{
	public class StudentFeedback
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Student name is required"), MaxLength(100)]
		public string? studentName { get; set; }
		public List<Question> questions { get; set; } = new();

		public StudentFeedback()
		{

		}
	}
}
