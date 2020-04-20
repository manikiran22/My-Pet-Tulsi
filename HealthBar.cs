using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    float maxHealth = 100f;
    public float currHealth = 20f;

    public Gradient gradient;
    public Image fill;

    public GameManagers gameManager;

    public Animator animator;

    private void Start()
    {
        slider.maxValue = maxHealth;
        slider.value = currHealth;
        gameManager = FindObjectOfType<GameManagers>();
    }

    private void Update()
    {
        //slider.value -= 0.01f;
        //currHealth = slider.value;
        gradientColor();
        animator.SetFloat("STH", currHealth);
    }

    public void SetHealth(float health)
    {
        slider.value = health;
        
        Debug.Log(currHealth);
    }

    public void gradientColor()
    {
        if (currHealth >= 50)
        {
            fill.color = gradient.Evaluate(1f);
        }
        else
        {
            fill.color = gradient.Evaluate(slider.normalizedValue);
        }
    }

/*    void MaxDamage()
    {
        if (currHealth > 100)
        {
            currHealth = 100;
        }
    }*/

  /*  void MinDamage()
    {
        if (currHealth < 0)
        {
            currHealth = 0;
        }
    }*/
}
