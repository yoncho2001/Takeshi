using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Takeshi;

public abstract class Hero
{
    protected string name;
    protected int healthPoints;
    protected int strength;
    protected Armor armor;
    protected List<Ability> abilities;
    protected Weapon primaryWeapon;

    public Hero()
    {
        this.name = name;
        this.healthPoints = 0;
        this.strength = 1;
        this.armor = new Armor();
        this.abilities = new List<Ability>();
        this.primaryWeapon = new Weapon();
    }

    public Hero(string name, int healthPoints, int strength, Armor armor, List<Ability> abilities, Weapon primaryWeapon)
    {
        this.name = name;
        this.healthPoints = 0;
        this.strength = 1;
        this.armor = new Armor();
        this.abilities = new List<Ability>();
        this.primaryWeapon = new Weapon();
    }

    public string Name
    {
        get
        {
            return this.name;
        }
    }

    public int HalthPoints
    {
        get
        {
            return this.healthPoints;
        }
    }
    public int Strength
    {
        get
        {
            return this.strength;
        }
    }

    public Weapon PrimaryWeapon
    {
        get
        {
            return this.primaryWeapon;
        }
    }

    public List<Ability> Abilities
    {
        get
        {
            return this.abilities;
        }
    }

    public Armor Armor
    {
        get
        {
            return this.armor;
        }
    }
}

public class Mele : Hero
{
    private Weapon secondaryWeapon;

    public Weapon SecondaryWeapon
    {
        get
        {
            return this.secondaryWeapon;
        }
    }

    public void SwitchWeapon()
    {
        Weapon temp = primaryWeapon;
        primaryWeapon = secondaryWeapon;
        secondaryWeapon = temp;
    }
}

public class Range : Hero
{
    private int ammo;

    public int Ammo
    {
        get
        {
            return this.ammo;
        }
    }

    public void DecreaseAmmo(int amount)
    {
        this.ammo -= amount;
    }
}

public class Mage: Hero
{
      private int mana;

    public int Mana
    {
        get
        {
            return this.mana;
        }
    }

    public void DecreaseMana(int amount)
    {
        this.mana -= amount;
    }
}