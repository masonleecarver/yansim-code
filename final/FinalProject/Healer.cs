public class Healer : Item 
{
    int _healAmount;

    public Healer(string name, string description, int value, int healAmount)
        :base(name, description, value)
    {
        _healAmount = healAmount;
    }

    public void Heal(Player player)
    {
        Console.WriteLine($"Used a {_name}.");
        player.GetHealed(_healAmount);
        if (player.GetHealth() > player.GetMaxHealth())
        {
            player.ManualHealth(player.GetMaxHealth());
        }
        Console.WriteLine($"Healed {_healAmount} HP.");
    }

}