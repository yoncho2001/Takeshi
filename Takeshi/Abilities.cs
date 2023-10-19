using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Takeshi;

public abstract class Ability
{
    private string name;
    private List<HeroClassType> heroClassTypes;
    private int cooldown;
    private int? cost;
    private int damage;

    public Ability(string? name, List<HeroClassType> heroClassTypes, int cooldown, int? cost = null)
    {
        this.name = name;
        this.heroClassTypes = heroClassTypes;
        this.cooldown = cooldown;
        this.cost = cost;
    }

    public abstract int Effect(Hero attacker);
    public bool canLearn(string attacker)
    {
        for (int i = 0; i < heroClassTypes.Count; i++)
        {
            if (heroClassTypes[i].ToString() == attacker)
            {
                return true;
            }
        }
        
        return false;
    }
}

public abstract class BasicAttack: Ability
{
    private string name;
    private List<HeroClassType> heroClassTypes;
    private int cooldown;
    private int? cost;

    public BasicAttack() : base("BasicAttack", new List<HeroClassType> { HeroClassType.Mele, HeroClassType.Range, HeroClassType.Mage }, 0, 0)
    {}

    public override int Effect(Hero attacker)
    {
        int damage = attacker.PrimaryWeapon.DamagePoints + attacker.Strength;

        if (attacker is Range rangeHero)
        {
            rangeHero.DecreaseAmmo(1);
        }

        return damage;
    }
}

public abstract class HardAttack : Ability
{
    private string name;
    private List<HeroClassType> heroClassTypes;
    private int cooldown;
    private int? cost;

    public HardAttack() : base("HardAttack", new List<HeroClassType> { HeroClassType.Mele, HeroClassType.Range }, 2, 0)
    {}

    public override int Effect(Hero attacker)
    {
        int damage = 2 * attacker.PrimaryWeapon.DamagePoints + attacker.Strength;

        if (attacker is Range rangeHero)
        {
            rangeHero.DecreaseAmmo(1);
        }

        return damage;
    }
}