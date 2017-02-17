using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    private List<GameObject> enemies;

    public PlayerStats playerStats;

    bool enemyInRange;
    float timer;

	void Start ()
    {
        enemies = new List<GameObject>();
	}
	
	void Update ()
    {
        timer += Time.deltaTime;

        if (Input.GetAxis("Fire1") == 1f)
        {
            if(timer >= playerStats.playerWeapon.attackSpeed && enemyInRange)
            {
                Attack();
                Debug.Log("Fire!!!");
            }
        }
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            enemies.Add(other.gameObject);
            enemyInRange = true;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemies.Remove(other.gameObject);
            enemyInRange = false;
        }
    }

    void Attack()
    {
        timer = 0f;

        foreach(GameObject enemy in enemies)
        {
            EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();

            if(enemyHealth.currentHealth > 0)
            {
                enemyHealth.TakeDamage(playerStats.playerWeapon.attack);
                Debug.Log("Enemy Damaged");
            }

        }
    }
}
