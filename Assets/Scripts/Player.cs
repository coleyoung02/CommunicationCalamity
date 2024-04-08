using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LeftRightMovement();
    }

    //needs to be implemented
    public void TouchGround()
    {
        return;
    }

    //Done, depending on how you implement future features, you may need to touch it though...
    private void LeftRightMovement()
    {
        float lrMag = 0;
        if (Input.GetKey(KeyCode.A))
        {
            lrMag -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            lrMag += 1;
        }
        Vector2 v = rb.velocity;
        v.x = lrMag * maxSpeed;
        rb.velocity = v;
    }

}
