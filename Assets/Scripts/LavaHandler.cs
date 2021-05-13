using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaHandler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("In the Lava!!");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = new Vector2(0, 0);    
            GameStats.Reset();
        }
    }

}
