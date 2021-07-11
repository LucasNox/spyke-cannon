using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 100;
    private int currentHealth;
    [SerializeField]
    private HealthBar hpBar;
    private bool dead = false;

    private void Start() {
        currentHealth = maxHealth;
        hpBar.SetMaxHealth(maxHealth);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Damager dmg = other.gameObject.GetComponent<Damager>();
        if (dmg)
        {
            TakeDamage(dmg.Damage);
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("DeathScene");
        }
        hpBar.SetHealth(currentHealth);
    }
}
