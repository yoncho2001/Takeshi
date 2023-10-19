using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takeshi;

public class Weapon
{
    private string name;
    private int damagePoints;
    private HeroClassType heroClassType;

    public Weapon()
    {
        this.name = "Default";
        this.damagePoints = 0;
        this.heroClassType = HeroClassType.Mele;
    }

    public Weapon(string? name, int damagePoints, HeroClassType heroClassType)
    {
        Validate.isString(name);

        this.name = name;
        this.damagePoints = damagePoints;
        this.heroClassType = heroClassType;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
    }

    public int DamagePoints
    {
        get
        {
            return this.damagePoints;
        }
    }
    public HeroClassType HeroClassType
    {
        get
        {
            return this.heroClassType;
        }
    }
}
