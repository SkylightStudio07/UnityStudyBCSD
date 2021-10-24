using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 행동에 대해서 설명해 보세요.
// 지형에서 움직인다.
// 몬스터를 공격한다.
// NPC와 대화한다.
// 스킬을 사용한다.

class Player
{
    // 명사만으로는 부족해...
    int ATK;
    int HP;

    // 행동으로 나타나게 된다..
    // 이런 것들을 표현하는 것을 멤버 함수라고 이른다.
    // 굉장히 다양한 방법으로 함수를 선언할 수 있지만.

    /*리턴값*/
    void Move ()
    { // <- 함수 시작

    } // <- 함수 끝

    void Fight()
    {

    }

    void SkillUse()
    {

    }

    void Talk()
    {

    }
}

// RPG를 만든다 -> 프로젝트를 만든다.
// 주인고잉 있다 -> 클래스
// 주인공이 공격력을 있다. -> 멤버변수
// 주인공이 공격력으로 때린다. -> 멤버함수