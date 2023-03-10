using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 10;
    private Rigidbody2D rigBody;
    private Vector2 moveInput;


    // Start is called before the first frame update
    void Start()
    {
        rigBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rigBody.velocity = moveInput * moveSpeed;

    }
}
