using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Animator playerAnim;
    public float speed;

    Vector3 movement;           

    void Awake() {

    }

    void FixedUpdate() {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h, v);
        Animating(h, v);
    }

    void Move(float h, float v) {
        float horizontal = h * speed * Time.deltaTime;
        transform.Translate(horizontal, 0, 0);

        float vertical = v * speed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }

    void Animating(float h, float v) {
        bool walking = h != 0f || v != 0f;

        playerAnim.SetBool("IsWalking", walking);
    }
}
