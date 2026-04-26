using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    public Health playerHealth;
    private Slider slider;
    public TextMeshProUGUI healthText;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        if (playerHealth != null)
        {
            slider.value = playerHealth.currentHealth;
         
            if (healthText != null)
            {
                healthText.text = playerHealth.currentHealth.ToString("F0") + " / " + playerHealth.maxHealth.ToString("F0");
            }
        }
    }
}
