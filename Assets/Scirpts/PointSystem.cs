using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public static int point = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.name == "Char"){
            point++;
            Debug.Log(point);
            Destroy(gameObject);
         }
    }
}
