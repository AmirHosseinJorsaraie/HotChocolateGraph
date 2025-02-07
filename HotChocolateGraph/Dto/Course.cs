namespace HotChocolateGraph.Dto
{
    public class Course
    {
        [GraphQLNonNullType]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int TeacherId { get; set; }
    }
}
