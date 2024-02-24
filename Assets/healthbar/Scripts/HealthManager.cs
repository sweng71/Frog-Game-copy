using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;
    public float targetTime = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f)
        {
            targetTime = 5.0f;
            Healthcost(5);
        }
        
        // if (healthAmount <= 0)
        // {
        //     [the code of ending screen]
        // }
        // what you might need to do:
        if (healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Debug.Log("space");
            Healthcost(2);
        }


        // if ([the code of flies be eatten])
        // {
        //     Heal(10);
        // }
        // what you might need to do: 
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(10);
        }
    }

    public void Healthcost(float cost)
    {
        healthAmount -= cost;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100f;
    }
}
