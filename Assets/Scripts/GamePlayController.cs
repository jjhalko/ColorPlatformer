using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController instance;

    private Text RedText;
    private Text GreenText;
    private Text BlueText;
    private Text AffinityText;

    void Awake()
    {
        RedText = GameObject.Find("RedText").GetComponent<Text>();
        GreenText = GameObject.Find("GreenText").GetComponent<Text>();
        BlueText = GameObject.Find("BlueText").GetComponent<Text>();
        AffinityText = GameObject.Find("AffinityText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        RedText.text = GameStats.CountRed.ToString();
        GreenText.text = GameStats.CountGreen.ToString();
        BlueText.text = GameStats.CountBlue.ToString();

        switch (GameStats.Affinity) {
            case AffinityColor.Red:
                AffinityText.text = "RED";
                AffinityText.color = Color.red;
                break;
            case AffinityColor.Blue:
                AffinityText.text = "BLUE";
                AffinityText.color = Color.blue;

                break;
            case AffinityColor.Green:
                AffinityText.text = "GREEN";
                AffinityText.color = Color.green;
                break;
        }


    }
}
