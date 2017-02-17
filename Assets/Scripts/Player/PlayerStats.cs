using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public float movementSpeed = 10f;
    public PlayerWeapon playerWeapon;

    bool isDead;
    bool damaged;

    // Use this for initialization
    void Awake ()
    {
        currentHealth = startingHealth;

        playerWeapon = new Sword();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void TakeDamage(int amount)
    {
        damaged = true;

        Debug.Log("Damaged");

        currentHealth -= amount;

        //healthSlider.value = currentHealth;

        if (currentHealth <= 0 && !isDead)
        {
            //Death();
        }
    }


    void Death()
    {
        isDead = true;

        gameObject.GetComponent<PlayerMovement>().enabled = false;
    }
}
