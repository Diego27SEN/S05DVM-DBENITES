using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth = 100f;

    [FoldoutGroup("Eventos")]
    public UnityEvent OnTakeDamage;

    [FoldoutGroup("Eventos")]
    public UnityEvent OnDeath;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        OnTakeDamage.Invoke();

        if (currentHealth <= 0)
        {
            OnDeath.Invoke();
        }
    }
    public void KillObject()
    {
        Destroy(gameObject);
    }

}
