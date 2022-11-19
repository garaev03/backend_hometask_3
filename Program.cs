namespace hometask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student("samir","garayev","BB-202", 79, false);

            student.getDetails();
            student.secondExam();
        }
    }
}