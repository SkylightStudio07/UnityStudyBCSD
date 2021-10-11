using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 문법을 공부할 때
// 응용법까지 욕심내는 경우가 있다.
// 게임 프로그래밍에서는
// 실제 코드를 짜면서 보기 전까지는
// 응용에 대해서 느낄 수가 없어요
// 프로그래밍에서는 경우가 무한대이다.
// 배열이라는 것을 배웠다.
// 인벤토리 만들 때 쓸 수 있다.
// 오브젝트를 관리할 때 쓸 수 있다.

// 프로그래머가 2명이다.
// RPG를 만들기로 했다

// A 프로그래머 - HP포션
// B 프로그래머 - MP포션

    // HP포션
class Potion
{
    // 마시면 HP 차는내용
}

// 식별자가 겹칠 때의 문제는
// 사용할 때이다.
// P

// MP포션
class Potion // 코드가 부적절
{
    // 
}

// ->

// A프로그래머
// 네임스페이스는 개념의 표현이라기 보다는
// 표현의 분류
namespace APRO // 어떤 코드를 어떤 이름으로 분류
{
    class /*APRO.*/Potion // 코드가 부적절
    {
        // 
    }
}
// B프로그래머
namespace BPRO // 어떤 코드를 어떤 이름으로 분류
{
    class /*BPRO.*/Potion // 코드가 부적절
    {
        // 
    }
}
class Player
{

}

namespace _02NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
