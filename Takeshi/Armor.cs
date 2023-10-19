using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takeshi;

public class Armor
{
    private string name;
    private int armorPoints;
    private List<Potion> potionSlots;

    public Armor()
    {
        this.name = "Default";
        this.armorPoints =0;
        this.potionSlots = new List<Potion>();
    }

    public Armor(string? name, int armorPoints)
    {
        Validate.isString(name);

        this.name = name;
        this.armorPoints = armorPoints;
        this.potionSlots = new List<Potion>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }
    }

    public int ArmorPoints
    {
        get
        {
            return this.armorPoints;
        }
    }

    public void addPotion(Potion potion) 
    {
        potionSlots.Add(potion);
    }

    public void usePotion(Potion potion)
    {
        potionSlots.Remove(potion);
    }
}
