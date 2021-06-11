using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMovement : MonoBehaviour
{
    public float speed, jumpSpeed;
    public Rigidbody Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Player.AddForce(jumpSpeed * Vector3.up, ForceMode.VelocityChange);
        }
    }

    void FixedUpdate()
    {
        OnMove();
    }

    void OnMove()
    {
        float x, z;
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        Vector3 ballSpeed = new Vector3(x, 0, z) * Time.fixedDeltaTime * speed;
        Player.AddForce(ballSpeed, ForceMode.Impulse);
    }

}
