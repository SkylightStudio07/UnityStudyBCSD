using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    protected string Name = "None";
    protected int AT = 10;
    protected int HP = 100;

    // 이 문법의 핵심은
    // 자식에서 만약 나의 Getaat를 재구현했다면
    // 자식의 형태의 GetAT를 호출해 주세요.
    // 이걸 오버라이딩
    // 다형성(동적바인딩)의 핵심 문법 중 하나이다.
    // 생성자 오버라이딩 불가
    //public virtual int GetAT()
    //{
      //  Console.WriteLine("FIGHTUNIT의 GETAT");
       // return AT;
    //}

    // 프로퍼티는 VIRTUAL 사용 가능
    public virtual int DMGAT
    {
        get
        {
            return AT;
        }
    }

    // 업캐스팅
    // DamageFightUnit
    // 첫번째 상속의 개념을 지키기 위해서
    // (코드 재활용성)(코드를 적게 치고 최대한의 효과를 누리고 싶다.)
    public void Damage(FightUnit _OtherFightUnit)
    {
        // 각자 플레이어면 플레이어의 것

        int AT = _OtherFightUnit.DMGAT;

        Console.WriteLine(_OtherFightUnit.Name + "에게" + AT + "만큼의 데미지를 입었습니다.");
        HP -= AT;
    }
    // 오버로딩
    // DamagePlayer
   // public void Damage(Player _OtherFightUnit, int _DamgePlus)
    //{
     //   Console.WriteLine(_OtherFightUnit.Name + "에게" + _OtherFightUnit.AT + "만큼의 데미지를 입었습니다.");
      //  HP -= _OtherFightUnit.AT;
    //}
}

class Player : FightUnit
{
    int ItemAT = 5;

    // 이 문법의 핵심은
    // 자식에서 만약 나의 Getaat를 재구현했다면
    // 자식의 형태의 GetAT를 호출해 주세요.
    public override int DMGAT
    {
        get
        {
            Console.WriteLine("플레이어의 GETAT");
            return (AT + ItemAT);
        }
    }

    public Player(string _Name)
    {
        Name = _Name;
    }
}
class Monster : FightUnit
{
    int MonsterLV = 12;

    public override int DMGAT
    {
        get
        {
            Console.WriteLine("몬스터의 GETAT");
            return AT + MonsterLV;
        }
    }
    public Monster(string _Name)
    {
        Name = _Name;
    }
}

namespace _30Overraiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player("플레이어");
            Monster NewMonster = new Monster("몬스터");

            

            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
        }
    }
}
