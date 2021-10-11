using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 멤버변수 => 클래스 내부에 있다고 해서 멤버변수
    //

    int ATK;
    int DEF;
    int HP;

    void Fight()
    {
        // 선언되는 순간 지역변수는 메모리화되고

        int Damage = 0; // 지역변수

        Console.WriteLine("플레이어가 싸운다.");
    }
}// 게임에서 사용하기 위해 여기까지 설계했다.

namespace _06LocalVar
{
    // C#은 고지식한 객체지향 언어.
    // 클래스밖에 모르는 언어.
    // 프로그램의 시작조차도
    // 클래스 안에 묶어놓아야 한다.

    
    class Program
    {
        static void Main(string[] args)
        {
            // 함수 안에 있는 녀석들을 지역변수라고 이름/.
            int ATK = 0;
            ATK = 50;
            // 지역변수 규칙 1
            // {
            //  내부에서만 사용가능.
            //  }

            // 객체화라고 하는 굉장히 중요한 작업.
            // 클래스는 일종의 설계도.
            // Player의 설계대로 플레이어를 만드는데.
            // 그 이름을 NewPlayer이라고 해서.
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();

            // Console.WriteLine("지역변수를 공부하여 봅시다.");
        }
    }
}
