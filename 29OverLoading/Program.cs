using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Player
{

    public Player()
    {

    }
    public Player(int _HP) // 생성자 오버로딩
    {
        Hp = _HP;
    }

    public enum DMGTYPE
    {
        PYDMG,
        FIREDMG,
        ICEDMG
    }

    int AttDef = 5;
    int FireDef = 5;
    int IceDef = 5;

    int Hp = 100;

    static void Func(int _Value)
    {

    }

    // Damage int
    // 함수 오버로딩
    public void Damage(int _Damage)
    {
        Hp -= _Damage;
    }
    //Damage float int
    public void Damage(float _dddd, int _Damage)
    {

    }
    // Damage int int
    public void Damage(int _Damage, DMGTYPE _Type)
    {
        switch (_Type)
        {
            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;
            default:
                break;
        }
        Damage(_Damage);
    }
}
namespace _29OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.Damage(100, Player.DMGTYPE.FIREDMG);
        }
    }
}
