using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animation;
    public Rigidbody2D rb;
    public Transform move;
    float thrust = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("d")){
           move.position += new Vector3(3 * Time.deltaTime, 0, 0);
           animation.SetFloat("Speed", 1);
        } else if (Input.GetKey("a")){
            move.position += new Vector3(-3 * Time.deltaTime, 0, 0);
            animation.SetFloat("Speed", 1);
        } else if (Input.GetKey("w")){
            move.position += new Vector3(0 , 10 * Time.deltaTime, 0);
            animation.SetFloat("Jump", 1);
        } else {
             animation.SetFloat("Speed", 0);
             animation.SetFloat("Jump", 0);
        }
    }
}
