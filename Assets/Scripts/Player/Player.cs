using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    PlayerStats playerStats;
    PlayerMovement playerMovement;
    PlayerAttack playerAttack;

    Animator anim;
    Rigidbody playerRigidbody;

	void Start ()
    {
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
        playerStats = GetComponent<PlayerStats>();

        playerMovement = gameObject.AddComponent<PlayerMovement>();
        playerMovement.playerAnim = anim;
        playerMovement.speed = playerStats.movementSpeed;

        playerAttack = gameObject.AddComponent<PlayerAttack>();
        playerAttack.playerStats = playerStats;
	}
	
	void Update ()
    {
		
	}
}
