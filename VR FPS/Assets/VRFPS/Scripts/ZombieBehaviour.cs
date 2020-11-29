using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehaviour : MonoBehaviour
{
    private int currentHealth;
    public int health = 100;

    private Animator anim;

    private void Start()
    {
        currentHealth = health;

        anim = GetComponent<Animator>();
    }

    public void OnCollisionEnter(Collision other)
    {
        if (currentHealth > 0)
        {
            TakeDamage(Random.Range(5, 20));
        }
    }

    public void TakeDamage(int DamageType)
    {
        currentHealth -= DamageType;
        if(currentHealth <= 0)
        {
            anim.SetBool("Dead", true);
            new WaitForSeconds(2);
            Destroy(gameObject);
        }
        else
        {
            anim.SetTrigger("Hit");
        }
    }

}
