using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 4;
    public Transform target;
    private Vector2 startPos;
    Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            var distance = Vector2.Distance(transform.position, target.position);
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
