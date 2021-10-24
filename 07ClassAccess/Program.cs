using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 객체지향 프로그램이에서는
// 가장 처음으로 해야할 일이
// 내가 RPG 뭘 만들고 싶다
// class Dragon
// {
//  int AT;
//  int HP;
//
// }

class Player
{ // 클래스 내부
    // 객체 지향의 캡슐화 은닉화를 보호하는 문법
    // 접근제한 지정자입니다.

    public int ATK; // 외부에도 공개
    protected int HP; // 자식에게만 공개
    private int DEF; // 내부에만 공개

    public void Fight()
    {
        Console.WriteLine("펀치");
    }
} // 클래스 끝

namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            // 만들어진 객체의 내용을 사용하기 위해서는
            // 객체의 이름.을 사용한다.
            // 접근제한 지정자라는 문법을 사용하지 않아서
            // 외부에 공개하지 않기로 했다.

            // 잘못쓰기도 힘들게 만들어놔라.

            NewPlayer.Fight();
            NewPlayer.ATK = 1000;
        }
    }
}
