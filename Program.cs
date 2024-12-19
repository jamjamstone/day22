using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace day22
{
    enum enumtest
    {
        a,b,c,length//length는 현재 3, 0부터 인덱스 부여->0,1,2,3
    }
    static class Extend
    {
        public static void PrintReverse(this string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(new string(chars));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ///버블 소트
            ///
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 15, 11 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            ///선택정렬
            ///가장 작은걸 앞으로 보내는걸 반복하는 방식
            ///반복문을 돌면서 
            ///앞 인덱스부터 제일 작은걸 배치
            ///확장 메서드
            ///이미 만들어진 메서드를 수정 및 기능추가를 할 때 사용하는 메소드
            ///static 메소드로 만들어야만 가능하다. 
            ///메소드 인자에 this class명 변수명 형식으로 집어넣어야 한다.
            ///enum의 요소로 length를 넣어서 int로 형변환 하면 인덱스 관리하기 쉽다
            ///
            
            





        }
        
    }
}
