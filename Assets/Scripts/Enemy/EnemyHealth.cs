using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour {

    public int startingHealth = 100;            
    public int currentHealth;                   

    Animator anim;                              
    AudioSource enemyAudio;                     
    ParticleSystem hitParticles;                
    CapsuleCollider capsuleCollider;            
    bool isDead;                                


    void Awake()
    {
        //anim = GetComponent<Animator>();
        enemyAudio = GetComponent<AudioSource>();
        hitParticles = GetComponentInChildren<ParticleSystem>();
        capsuleCollider = GetComponent<CapsuleCollider>();

        currentHealth = startingHealth;
    }

    void Update()
    {
       
    }


    public void TakeDamage(int amount, Vector3 hitPoint)
    {
        if (isDead)
            return;

        currentHealth -= amount;

        hitParticles.transform.position = hitPoint;

        hitParticles.Play();

        if (currentHealth <= 0)
        {
            Death();
        }
    }


    void Death()
    {
        isDead = true;

        capsuleCollider.isTrigger = true;

        Destroy(gameObject, 2f);
    }
}
