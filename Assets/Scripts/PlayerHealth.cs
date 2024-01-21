using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health = 5;
    [SerializeField] private int _maxHealth = 15;
    [SerializeField] private HealthUI HealthUI;

    [SerializeField] private AudioSource TakeDamageSound;
    [SerializeField] private AudioSource AddHealthSound;
  
    [SerializeField] private Gama Gama;

    private bool _invulnerable = false;

    public void Start()
    {
        HealthUI.Setup(_maxHealth);
        HealthUI.DisplayHealth(_health);
    }

    public void TakeDamage(int damageValue)
    {
        if (_invulnerable == false)
        {
            _health -= damageValue;
            if (_health <= 0)
            {
                _health = 0;
                Die();
            }

            _invulnerable = true;
            Invoke("StopInvulnerable", 1f);
            if (_health > 0)
            {
                TakeDamageSound.Play();
            } else
            {
                TakeDamageSound = null;
            }

            HealthUI.DisplayHealth(_health);
        }
    }

    void StopInvulnerable()
    {
        _invulnerable = false;
    }
    public void AddHealth(int healthValue)
    {
        _health += healthValue;
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
        AddHealthSound.Play();
        HealthUI.DisplayHealth(_health);
    }
    public void Die()
    {
        Debug.Log("You Lose");
        
        Destroy(gameObject);
        TakeDamageSound = null;
        Gama.StopScene();
       
    }
}
