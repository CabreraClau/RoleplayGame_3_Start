using System.Collections.Generic;

namespace RoleplayGame;
public class Field
{
    public List<Enemy> ListEnemies;
    public List<Hero> ListHeroes;
    public Field(List<Enemy> enemies, List<Hero> heroes)
    {
        this.ListEnemies = enemies;
        this.ListHeroes = heroes; 
    }
    public void DoEncounter()
    {
        List<Enemy> enemies = this.ListEnemies;
        List<Hero> heroes = this.ListHeroes;
        if (enemies.Count >0 && heroes.Count >0 )
        {
            if (enemies.Count == heroes.Count)
            {
                int i = 0;
                foreach (Enemy enemy in enemies)
                {
                    Hero hero = heroes [i];
                    hero.ReceiveAttack(enemy);
                }
            }
        }
    }
}