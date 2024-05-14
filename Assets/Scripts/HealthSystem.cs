using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class HealthSystem : MonoBehaviour
{
    private float healthPoints;
    private float maxHealth;


    public HealthSystem(int maxHealth)
    {
        this.maxHealth = maxHealth;
        healthPoints = maxHealth;
    }
    public float getHealth() { return healthPoints; }
    public float GetHealthPrecentage() { return healthPoints / maxHealth; }

    public void Damage(int DamageAmount)
    {
        healthPoints -= DamageAmount;
        if (healthPoints <= 0) healthPoints = 0;
    }

    public void Heal(int HealAmout)
    {
        healthPoints += HealAmout;
        if (healthPoints > maxHealth) { healthPoints = maxHealth; }

    }
}
