using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth {  get; private set; }

    public Stat damage;
    public Stat armor;


    void Awake()
    {
        currentHealth = maxHealth;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }


    public void TakeDamage(int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }


    public virtual void Die()
    {

    }
}
