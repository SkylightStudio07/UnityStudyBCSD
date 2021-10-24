using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 사용자 정의 자료형인데
interface QuestUnit
    {
    // 멤버변수 X
    // int A = 0;

    // 함수의 형태만 물려줄 수 있는 문법이다.
    void Talk(QuestUnit _OtherUnit);
    // 사용 불가
    // { } 인터페이스 문법에는 정의 사용 불가
    void Event(QuestUnit _OtherUnit);
}
interface QuestUnit2
{
    // 멤버변수 X
    // int A = 0;

    // 함수의 형태만 물려줄 수 있는 문법이다.
    void Talk(QuestUnit _OtherUnit);
    // 사용 불가
    // { } 인터페이스 문법에는 정의 사용 불가
    void Event(QuestUnit _OtherUnit);
}

public class FightUnit
{
    int AT;
    int DMG;

    public void Damage()
    {

    }
}
// 인터페이스는 함숟구현을 강제할 수 있다.
// 인터페이스는 상속이라고 하지 않는 사람들도 있다.
// 포함의 개념이다-라고 말하느 사람도 있다.
// 인터페이스를 상속받았다고 치면
// 나는 talk

class Player : FightUnit, QuestUnit, QuestUnit2
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void Event(QuestUnit _OtherUnit)
    {

    }
}

class NPC : FightUnit, QuestUnit, QuestUnit2
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void Event(QuestUnit _OtherUnit)
    {

    }
}

namespace _31Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NPC NewNPC = new NPC();
            // QuestUnit Questunit = new QuestUnit();
            // 단독구현 불가

            QuestUnit NewQuestUnit = NewNPC;
            // NewQuestUnit.Damage(); 자신의 함수만 구현 가능

            // 업캐스팅 가능
            NewPlayer.Talk(NewNPC);
            NewNPC.Talk(NewPlayer);
        }

    }
}
