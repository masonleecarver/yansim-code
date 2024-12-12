public class Battle 
{
    List<Character> _fighters;
    List<Character> _enemies;
    List<Character> _fightersCopy;
    List<Character> _enemiesCopy;
    Player _player1;
    bool _over = false;

    Random random = new();

    public Battle(List<Character> enemies, Player player1) 
    {
        _enemies = enemies;
        _enemiesCopy = new List<Character>(_enemies);
        _player1 = player1;
        _fighters = new List<Character>(_enemies);
        _fighters.Add(_player1);
        _fighters = _fighters.OrderByDescending(fighter => fighter.GetSpeed()).ToList();
        _fightersCopy = new List<Character>(_fighters);

    }

    public void Turn()
    {
        do
        {
            List<Character> toRemove = new();

            foreach(Character fighter in _fighters)
            {

                if (_fighters.All(fighter => fighter is Enemy))
                {
                    _over = true;
                    Console.WriteLine("You lost...");
                    Thread.Sleep(2000);
                    Console.WriteLine("But you need to do it again until you win.");
                    Reset();
                    toRemove.Clear();
                    Turn();
                    break;
                }

                else if (_fighters.All(fighter => fighter is Player))
                {
                    _over = true;
                    Console.WriteLine("You've won!");
                    _player1.LevelUp();
                    break;
                }

                else if (_over == true)
                {
                    break;
                }

                else 
                {

                    if (fighter is Player && fighter.GetAlive())
                    {
                        Console.WriteLine($"{fighter.GetName()}'s turn!");
                        Thread.Sleep(1000);
                        
                        toRemove.AddRange(PlayerTurn(_player1));
                    }

                    else if (fighter is Enemy enemy && fighter.GetAlive() && _player1.GetAlive())
                    {
                        Console.WriteLine($"{fighter.GetName()}'s turn!");
                        Thread.Sleep(1000);
                        
                        enemy.Attack(_player1);
                        if (_player1.GetAlive() == false)
                        {
                            Console.WriteLine($"{_player1.GetName()} has died.");
                            toRemove.Add(_player1);
                        }
                    }
                }
            }

            foreach (Character character in toRemove)
            {
                _fighters.Remove(character);

                if (character is Enemy enemy)
                {
                    _enemies.Remove(enemy);
                }
            }
        }
        while(_over != true);
    }

    public List<Character> PlayerTurn(Player player)
    {

        List<Character> toRemove = new();

        if (_over == true)
        {
            return toRemove;
        }

        Console.Clear();
        Console.WriteLine($"What will {player.GetName()} do?\n\t1. Attack\n\t2. Use Item\n\t3. Check Stats\n\t4. Run away??\n\t5. Kill the game.");
        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("Who to attack...\n");

            for (int i = 0; i < _enemies.Count; i++)
            {
                Console.WriteLine($"\t{i+1}. {_enemies[i].GetName()}");
            }
            Console.Write(" ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;
            Character enemyChoice = _enemies[choice];
            player.Attack(enemyChoice);
            if (enemyChoice.GetAlive() == false)
            {
                Console.WriteLine($"{enemyChoice.GetName()} was defeated B)\n");
                toRemove.Add(enemyChoice);
            }
        }

        else if (input == "2")
        {
            List<Healer> healers = _player1.GetInventory().OfType<Healer>().ToList();

            if (healers.Count <= 0)
            {
                Console.WriteLine("You have no items.");
            }

            else
            {
                Console.WriteLine("Which item to use...\n");
                for (int i = 0; i < healers.Count; i++)
                {
                    Console.WriteLine($"\t{i+1}. {healers[i].GetName()}");
                }
                Console.Write(" ");
                int choice = Int32.Parse(Console.ReadLine()) - 1;
                Healer healerChoice = healers[choice];
                healerChoice.Heal(_player1);
                _player1.RemoveInventory(healerChoice);
            }
        }

        else if (input == "3")
        {
            CheckStats();
        }

        else if (input == "4")
        {
            RunAway();
        }

        else if (input == "5")
        {
            _over = true;
            return toRemove;
        }

        else
        {
            Console.WriteLine("You just skipped your turn. Oops!");
        }

        return toRemove;

    }

    public void CheckStats()
    {
        foreach (Character fighter in _fighters)
        {
            Console.WriteLine($"{fighter.GetName()}\n\t{fighter.GetHealth()}/{fighter.GetMaxHealth()} HP left\n\t{fighter.GetAttack()} ATK - {fighter.Defense()} DEF\n\n");
        }
        Thread.Sleep(4000);
        return;
    }

    public void RunAway()
    {
        int d10 = random.Next(10);
        if (d10 < 6)
        {
            Console.WriteLine("You couldn't run away.");
            Thread.Sleep(2000);
            return;
        }
        else
        {
            _over = true;
            Console.WriteLine("You ran away! Coward.");
            Thread.Sleep(2000);
            return;
        }
    }

    public void Reset()
    {
        _over = false;
        _fighters = new List<Character>(_fightersCopy);
        _enemies = new List<Character>(_enemiesCopy);
        foreach (Character fighter in _fighters)
        {
            fighter.ManualHealth(fighter.GetMaxHealth());
            fighter.SetAlive(true);
        }

    }

}