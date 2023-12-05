using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Rigidbody rb;
    float speed = 12f;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        /* ------------------------------------------------------------
        if (Input.GetKey(KeyCode.UpArrow) ) {
            rb.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            rb.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(-speed, 0f, 0f);
        }
        *****************************************/
        //float xInput = Input.GetAxisRaw("Horizontal");
        //float zInput = Input.GetAxisRaw("Vertical");

        float xSpeed = Input.GetAxisRaw("Horizontal") * speed;
        float zSpeed = Input.GetAxisRaw("Vertical") * speed;

        //Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //rb.velocity = newVelocity;
        rb.velocity = new Vector3(xSpeed, 0f, zSpeed);
    }

    public void Die() {
        gameObject.SetActive(false);

        GameManager manager = FindObjectOfType<GameManager>();
        manager.EndGame();
    }
}
