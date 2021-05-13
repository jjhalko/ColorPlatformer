using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
           
    private void Awake()
    {
        MakeSingleton();
    }

    private void Update()
    {
        if (Input.GetKeyDown("i")) GameStats.Affinity = AffinityColor.Red;
        else if (Input.GetKeyDown("o")) GameStats.Affinity = AffinityColor.Blue;
        else if (Input.GetKeyDown("p")) GameStats.Affinity = AffinityColor.Green;
    }

    private void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        } else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}

