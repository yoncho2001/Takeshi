using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takeshi;

public class Potion
{
    private string? name;
    private HeroField affectingField;
    private int affectingValue;

    public Potion()
    {
        this.name = "Empty";
        this.affectingField = HeroField.HealthPoints;
        this.affectingValue = 0;
    } 

    public Potion(string? name, HeroField affectingField, int affectingValue)
    {
        Validate.isString(name);

        this.name = name;
        this.affectingField = affectingField;
        this.affectingValue = affectingValue;
    }
}
