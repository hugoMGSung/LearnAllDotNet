using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChain2App
{
    class Program
    {
        delegate void ThereIsAFire(string location); // 대리자 선언.

        static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? 불났어요! 주소는 {location} 에요!"); 
        }

        static void ShotOut(string location)
        {
            Console.WriteLine($"불이야!! {location}에 불났어요!");
        }

        static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 나갑시다!!");
        }

        static void Main(string[] args)
        {
            ThereIsAFire fire = new ThereIsAFire(Call119);
            fire += new ThereIsAFire(ShotOut); // 기본문법
            fire += Escape; // 약식문법

            fire("문현동 전광빌라");
        }
    }
}
