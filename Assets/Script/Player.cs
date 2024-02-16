using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public FixedJoystick Joystick;
    public float moveSpeed;
    int score = 0;
    float hInput, vInput;
    public GameObject WinText;
    public int winscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void FixedUpdate()
    {
        hInput = Joystick.Horizontal * moveSpeed;
        vInput = Joystick.Vertical * moveSpeed;

        transform.Translate(hInput, vInput, 0);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Carrot")
        {
            score++;
            Destroy(collision.gameObject);
            if(score >= winscore)
            {
                WinText.SetActive(true);
            }
        }
    }
}
