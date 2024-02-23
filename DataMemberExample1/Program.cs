using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMemberExample1//字段使用案例
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stulist = new List<Student>();//创建List<T>类型的实例；
            for (int i=0;i<100;i++)
            {
                Student stu = new Student();//创建Student类型实例。
                stu.Age = i;
                stu.Score = i;
                stulist.Add(stu);
            }
            int totalAge = 0;
            int totalScore = 0;
            foreach(var item in stulist)//遍历列表中所有数据
            {
                totalAge += item.Age;//每有一个数据，将其年龄累加
                totalScore += item.Score;
               
            }
            int aveage= Student.ReportAveAge(totalAge);
            Console.WriteLine(aveage);
            Student.ReportAmount();//静态字段表示类型当前状态，不需要实例。

        }
    }
    public class Student
    {
        public int Age=18;//声明是进行初始化与在构造函数中进行初始一样
        public int Score;//变量声明：特性（可选） 修饰符 类型 变量声明器；虽然有分号，但不是语句。
        public static int Amount;//静态字段表示类型当前状态，不需要实例。
        public static int AveAge;//字段写在类体花括号里
        public static int AveScore;
        public Student()
        {
           // this.Age=18;
            Amount++;           //字段写在类体花括号里，如在方法体中就是局部变量
        }
        public static void ReportAmount()
        {
            Console.WriteLine(Amount);
        }
        public static int ReportAveAge(int total)
        {
            AveAge= total / Amount;
            Console.WriteLine(AveAge);
            return AveAge;
           
        }
        public static void ReportAveScore()
        {
            Console.WriteLine(AveScore);
        }

    }
}
