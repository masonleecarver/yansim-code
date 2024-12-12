public class Enemy : Character
{
    int _expGiven;
    int _moneyGiven;

    
    public Enemy(string name, int maxHealth, int speed, int attack, Weapon weapon, Armor armor, int expGiven, int moneyGiven) 
        :base(name, maxHealth, speed, attack, weapon, armor)
    {
        _expGiven = expGiven;
        _moneyGiven = moneyGiven;
    }

    public void ChangeAttack(int attack)
    {
        _attack = attack;
    }
    public override void Defeated(Character character)
    {
        if(character is Player player)
        {
            player.ChangeMoney(_moneyGiven);
            player.ChangeExp(_expGiven);
        }

        else
        {
            Console.WriteLine("What the HECK happened here??");
        }
    
    }
}