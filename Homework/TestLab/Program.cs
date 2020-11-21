using System;
using System.Text;

namespace TestLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Content con = new Content("dfgkbh");
            Content con1 = "elrgerhg";
            Content con2 = 1;
            Console.WriteLine(con1.Text);
            Test test = new Test(1);
            Test test1 = new Test("");
        }
    }
    public class Content
    {
        public string Text { get; }
        public int Id { get; }
        public Content(string text) { Text = text; }
        public Content(int id) { Id = id; }
        public static implicit operator Content (string text)=> new Content(text);
        public static implicit operator Content (int id)=> new Content(id);
    }
    public class Test
    {
        public Test(Content content) { }
    }
}
