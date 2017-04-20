[System.Serializable]
public class Attack : CombatAbilities
{
    public void attack()
    {
        AbilityName = "Attack";
        AbilityPower = 30; //combatPower;
    }
}