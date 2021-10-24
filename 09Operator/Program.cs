using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int HP = 100;
    void Damage(int _HP)
    {
        HP = HP - 10;
    }
    bool ReturnTrue()
    {
        return true;
    }
    public int Plus(int _Left, int _Right)
    {
        return _Left + _Right;
    }
}

namespace _09Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            int Left = 6;
            int Right = 3;

            Player NewPlayer = new Player();

            // 대입연산자.
            // 함수에서 리턴된 값이나 혹은 연산이 된 값을
            // 리터럴 값일때도 있다.
            // 그 값을 받을 수 있는 변수에 넣어줘라.

            // 산술연산자
            Result = NewPlayer.Plus(Left, Right);
            Result = Left + Right; // 더하기
            Result = Left - Right; // 빼기
            Result = Left * Right; // 곱셈
            Result = Left / Right; // 나누기
            Result = Left % Right; // 나머지

            Result = (Left + Right) * 10;

            // 이런 식으로
            // 산술 연산을 할 수 있고
            // 한가지 주의할 점은
            // 나누기와 나머지는 0을 넣으면 안된다
            // 10 / 0은? 컴퓨터에서는 제로디비전이라 해서 아예 오류 발생
            // 프로그램이 실행 도중 터질 정도의 오류이므로 주의해야 한다.

            // 연산자느 함수과 비슷합니다.

            // 비교연산자
            // 비교연산자는 논리형으로 리턴이 되는데
            // 논리형은 bool이라는 녀석이 있었을 것이다.
            // 정수를 넣어줄 수 있는데;

            // 불은 참과 거짓이 있게 되는데
            // 참과 거짓이 상수화된 것이 true와 false

            bool Bresult = true;
            Bresult = false;
            // 이런식으로 참과 거짓을 통해서
            // 나중에 배울 조건문에서 정말 유용하게 이용되게
            Bresult = Left > Right; // 더 큰가, 참이면 true 거짓이면 false
            Bresult = Left < Right; // 작은가
            Bresult = Left <= Right; // 이하인가
            Bresult = Left >= Right; // 이상인가
            Bresult = Left == Right; // 같은가
            Bresult = Left != Right; // 다른가

            // bool 논리 연산자
            // bool 논리 연산자는
            Bresult = true && false; // AND
            Bresult = true || false; // OR
            Bresult = true ^ false; // XOR 양쪽이 다르다면 TRUE
            Bresult = !true; // NOT

            // 축약 연산자
            Result += 0;
        }
    }
}
