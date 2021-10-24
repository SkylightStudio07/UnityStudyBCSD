using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 접근제항 지정자를 입력하지 않으면
    // 디폴트는 private
    // 일반적으로 속성에 접근하지 않도롣 하는 것이 좋다.
    // 공격력은 공격력 그 자체만으로 의미가 있지만
    // 그 의미가 명확해지지 않아요.
    // 공격력이 증가한다.

    private int AT = 10;
    private int HP= 100;
    private int lv = 100;

    // 플레이어 레벨이 얼마인지 알고 싶다.
    // 인자값이 아니고 리턴값을 사용
    // 리턴값이란 객체가 자신의 상태를 외부에 알려주는 용도
    // 알려주는 순간 함수가 끝나게 됨.
    // 리턴이라는 문장을 사용하면 어떤 코드가 return 아래에 있건 함수는 종료된다.
    public int GetLv()
    {
        return lv;

        lv = 10000; // 리턴하는순간 이미 함수는 끝났기에 의미가 없음
    }

    // 상태라는 것은 멤버변수
    // 어떤 상태가 변화하는 순간
    // 각각 증가시키거나

    public void LVUP()
    {
        AT = 100;
        HP = 1000;
    }

    public void SetHP(int HP)
    {
        // 내가 HP가 0이 되는 순간만 체크할 수도 있음
        // 내가 100이 되는 순간만 체크할 수도 있다.
        // 가장 큰 핵심은 디버깅이 된다

        this.HP = HP;

    }

    // 함수는 보통 선언과 내용으로 나뉘게 되는데
    // void(리턴값) Func[이름 혹은 식별자] () [인자값]
    public void Func()
    {

    }

    // 함수는 보통 클래스 외부와의 소통을 위해서 만든다.
    // Damage는 맞는다라는 뜻
    // int dmg를 넣는다는 것은
    // 외부에서 한개의 int값을 넣어서
    // 플레이어에게 전달해 주겠다라는 듯

    public void Damage1(int _Dmg)
    {
    }
    // 동일한 자료형으로 리턴해야 함
    public int DamageToHPReturn(int _Dmg, int _Dmg1, )
    {
        HP = HP - _Dmg;
        return HP;
    }

    // 인자가 두개가 될 수도...
    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }


    // 플레이어가 어떤 사양과 내용을 가졌다
    // 만든 것은 아니다
}

namespace _08FuncEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player();
            // 그래서 필요한 것이 함수이다.
            Newplayer.SetHP(1000);

            // 이런 식으로 외부으 ㅣ값을 받아서
            // 객체가 내부이 상태를 변화시키기 위해
            // 함수를 선언하는 경우가 많습니다.
            Newplayer.Damage1(10);
            Newplayer.Damage2(10, 5);

            Console.WriteLine(Newplayer.GetLv());
            Console.WriteLine(Newplayer.DamageToHPReturn(50, 30));
        }
    }
}
