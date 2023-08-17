using System.ComponentModel.DataAnnotations;

namespace InstructorFormCreation
{
	public class Question
	{
		public int Id { get; set; }
		[Required]
		public string? QuestionText { get; set; }
		[Required]
		public string? QuestionType { get; set; }
		public int Rating { get; set; }
		public bool IsTrue { get; set; }
		public string? WrittenAnswer { get; set; }
	}
}
