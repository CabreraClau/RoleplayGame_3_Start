namespace RoleplayGame;

public class Hero : Character
{
    protected Hero (string name) 
    : base (name)
    {

    }
    public virtual void AbsorbVP (Enemy enemy)
    {
        this.VictoryPoints += enemy.VictoryPoints;
    }
    public override void Cure ()
    {

    }
}