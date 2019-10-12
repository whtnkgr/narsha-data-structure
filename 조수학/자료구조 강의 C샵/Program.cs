using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 자료구조_강의_C샵
{
    class Program
    {
        static void Main(string[] args)
        {
            //1~45가 숫자 범위
            //1.사용자가 문자열 입력
            //1.1 문자열 ex) 1,2,3,4,5,6
            //1.2 중복된 숫자 검사
            //2. 랜덤 숫자 6개 생성
            //2.1중복된 숫자 검사
            //3.사용자 입력 숫자 출력
            //4.랜덤 숫자 출력
            //5.겹치는 숫자 갯수 숫자
            //Console.WriteLine(new Random().Next(1, 45));



            // 사용자의 입력을 받는다
            Console.WriteLine("예상하는 숫자 6개를 입력해주세요");
            string text = Console.ReadLine();
            Console.WriteLine(" ");
            //Console.WriteLine("1");


            // 사용자의 입력을 배열로 나눈다
            string[] splited = text.Split(',');
            //Console.WriteLine("2");

            // 중복이 아닐때까지 입력을 받는다
            while (isDuplicated(splited))
            {
                text = Console.ReadLine();

                splited = text.Split(',');
            }
            //Console.WriteLine("3");




            //랜덤 숫자르 만들 위한 객체
            Random rand = new Random();

            //랜덤 숫자를 담기위한 배열 객체 생성
            string[] input = new string[6];

            //랜덤 숫자를 초기화 해준다.
            for (int i = 0; i < 6; i++)
            {
                input[i] = rand.Next(1, 46).ToString();
            }

            //랜덤 숫자의 중복을 검사 해준다
            while (isDuplicated(input))
            {
                for (int i = 0; i < 6; i++)
                {
                    input[i] = rand.Next(1, 46).ToString();
                }
            }

            Console.WriteLine("예상한 숫자");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(splited[i]);
            }
            
            Console.WriteLine("---------------------");
            Console.WriteLine("실제 복권 숫자");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(input[i]);
            }
            
            Console.WriteLine("---------------------");

            Console.WriteLine("예상 맞은 숫자");
            Console.WriteLine(getOverlapCount(splited,input));

        }

        static bool isDuplicated(string[] param)    //중복 찾기 반복용
        {
            bool dup = false;
            for (int i = 0; i < param.Length; i++)
            {
                for (int j = 0; j < param.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        if (param[i].Equals(param[j]))
                        {
                            dup = true;
                            break;
                        }
                    }
                }

                if (dup == true)
                {
                    break;
                }
            }

            return dup;
        }

        static int getOverlapCount(string[] param1,string[] param2) //중복이된 갯수 체크
        {
            int count = 0;
            for(int i=0;i<6;i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (param1[i].Equals(param2[j]))
                    {
                        count++;
                    }
                
                }
            }

            return count;
        }
    }
}


