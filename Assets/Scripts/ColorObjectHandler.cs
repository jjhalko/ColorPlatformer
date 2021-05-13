using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObjectHandler : MonoBehaviour
{
    public AffinityColor Affinity;
    private Collider2D col;
    private Collider2D player1;
    private Collider2D player2;
    public AudioClip touchSound;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        player1 = GameObject.Find("Player").GetComponent<BoxCollider2D>();
        player2 = GameObject.Find("Player").GetComponent<CircleCollider2D>();
        playerAudio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerAudio.PlayOneShot(touchSound);
        }
    }

    private void OnCollisionLeave2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerAudio.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Affinity != GameStats.Affinity)
        {
            bool test1 = UnityEngine.Physics2D.GetIgnoreCollision(col, player1);
            if (!test1) UnityEngine.Physics2D.IgnoreCollision(col, player1, true);
            bool test2 = UnityEngine.Physics2D.GetIgnoreCollision(col, player2);
            if (!test2) UnityEngine.Physics2D.IgnoreCollision(col, player2, true);
        }
        else
        {
            bool test3 = UnityEngine.Physics2D.GetIgnoreCollision(col, player1);
            if (test3) UnityEngine.Physics2D.IgnoreCollision(col, player1, false);
            bool test4 = UnityEngine.Physics2D.GetIgnoreCollision(col, player2);
            if (test4) UnityEngine.Physics2D.IgnoreCollision(col, player2, false);
        }

    }
}
