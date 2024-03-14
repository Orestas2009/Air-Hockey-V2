using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Original : MonoBehaviour
{
    public float speed = 10;
    public AudioClip jumpSound;
    public AudioClip hitSound;
    public AudioClip scoreSound;
    Rigidbody2D rb;
    private AudioSource audioSource;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        //convert ui mouse coordinates to world coordinates
        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;

        //move the player towards the mouse according to given speed
        var target = Vector3.MoveTowards(transform.position, worldPos, speed * Time.fixedDeltaTime);
        var targetViewPort = Camera.main.WorldToViewportPoint(target);
        if (targetViewPort.x < 0.5f)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            rb.MovePosition(target);
        }
    }
}
