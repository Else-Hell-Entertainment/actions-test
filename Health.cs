public class Health
{
    private int _maxHealth = 100;
    private int _currentHealth = 100;
    private bool _isAlive = true;
    private bool _isImmortal = false;

    public int MaxHealth => _maxHealth;

    public int CurrentHealth
    {
        get => _currentHealth;
        set => _currentHealth = value;
    }

    public bool IsAlive => CurrentHealth > 0;

    public bool IsImmortal
    {
        get => _isImmortal;
        set => _isImmortal = value;
    }

    public Health() { }

    public void Heal(int amount)
    {
        Health += Math.Abs(amount);
    }

    public bool TakeDamage(int amount)
    {
        Health -= Math.Abs(amount);
        return IsAlive;
    }
}
