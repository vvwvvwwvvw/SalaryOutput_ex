using System;

namespace SalaryOutput_ex
{
    public class Salary
    {
        public string name;
        public int service_years; // 근무 년수
        public int group_bonus; // 부서 보너스
        public int getSalary()
        {
            return 200 + service_years * 2 + group_bonus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Salary w1 = new Salary();
            w1.name = "홍길동";
            w1.service_years = 10;
            w1.group_bonus = 20;
            Console.WriteLine("{0} 월급은 {1} 만원 입니다",w1.name , w1.getSalary());

            Salary w2 = new Salary();
            w2.name = "전우치";
            w2.service_years = 5;
            w2 .group_bonus = 18;
            Console.WriteLine("{0} 월급은 {1} 만원 입니다",w2.name , w2.getSalary());

            Console.Read();
        }
    }
}
