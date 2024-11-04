using System;

namespace SalaryOutput_ex
{
    public class Salary
    {
        public string name;
        public int service_years; // 근무 년수
        public int group_bonus; // 부서 보너스
        public Salary(string n , int s, int g)//생성자 생성
        {
            name = n;
            service_years = s;
            group_bonus = g;
        }
        public int getSalary(bool bSummer) // 메소드 인자 전달

        {
            if (bSummer == true)
            {
                return 200 + service_years * 2 + group_bonus + 40;
            }
            else
            {
                return  200 + service_years * 2 + group_bonus;
            }
        }
        public int getSalary()
        {
            return 200 + service_years * 2 + group_bonus;

        }
    }
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Salary w1 = new Salary(); // 객체 생성
        //    w1.name = "홍길동";
        //    w1.service_years = 10;
        //    w1.group_bonus = 20;
        //    Console.WriteLine("{0} 월급은 {1} 만원 입니다",w1.name , w1.getSalary());

        //    Salary w2 = new Salary(); // 객체 생성
        //    w2.name = "전우치";
        //    w2.service_years = 5;
        //    w2 .group_bonus = 18;
        //    Console.WriteLine("{0} 월급은 {1} 만원 입니다",w2.name , w2.getSalary());

        //    Console.Read();
        //}
        static void Main(string[] args)
        {
            Salary w1 = new Salary("홍길동",10,20); // 객체 생성
            // 여름 흎가비 포함하지 않은 월급 계산
            Console.WriteLine("{0} 월급은 {1} 만원 입니다",w1.name , w1.getSalary());

            Salary w2 = new Salary("전우치",5,18); // 객체 생성
            // 여름 휴가비 포함한 월급 계산
            Console.WriteLine("{0} 월급은 {1} 만원 입니다",w2.name , w2.getSalary(true));

            Console.Read();
        }
    }
}
