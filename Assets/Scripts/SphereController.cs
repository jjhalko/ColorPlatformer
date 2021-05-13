using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    SpriteRenderer sr;
    public AffinityColor Affinity;

    //GameStats stats;

    // Start is called before the first frame update
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        SetColor(Affinity);
        Debug.Log("I'm awake");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collided." + collision.gameObject.tag);
        if (collision.gameObject.tag == "Player" && GameStats.Affinity == Affinity)
        {
            GameStats.CollectSphere(Affinity);            
            Destroy(this.gameObject);
        }

    }

    //void Explode()
    //{
    //    ParticleSystem exp = GetComponent<ParticleSystem>();
    //    exp.Play();
    //}

    public void SetColor(AffinityColor c)
    {
        switch (c)
        {
            case AffinityColor.Red:
                sr.color = new Color(1.0f, 0.0f, 0.0f);
                break;
            case AffinityColor.Blue:
                sr.color = new Color(0.0f, 0.0f, 1.0f);
                break;
            case AffinityColor.Green:
                sr.color = new Color(0.0f, 1.0f, 0.0f);
                break;
        }
    }

}

