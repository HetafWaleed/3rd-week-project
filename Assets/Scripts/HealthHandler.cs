using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthHandler : MonoBehaviour
{
    public Slider Slider;
    HealthSystem healthSystem = new HealthSystem(100);

    public void Update()
    {
        Slider.value = healthSystem.GetHealthPrecentage();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            healthSystem.Damage(10);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Heal")
        {
            healthSystem.Heal(10);
        }
    }
}
