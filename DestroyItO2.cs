using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItO2 : MonoBehaviour
{


    public HealthBar healthBar;
    public GameManagers gameManager;


    private void Start()
    {
        healthBar = FindObjectOfType<HealthBar>();
        gameManager = FindObjectOfType<GameManagers>();
    }

    void OnMouseDown()
    {

            TakeDamage(5);
            Destroy(gameObject);
    }

    void TakeDamage(int damage)
    {
        healthBar.currHealth += damage;
        healthBar.SetHealth(healthBar.currHealth);
        if (healthBar.currHealth > 100)
        {
            healthBar.currHealth = 100;
            gameManager.WinGame();
        }
    }
    }
