using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStats {

    public static int CountRed =0;
    public static int CountGreen =0;
    public static int CountBlue = 0;
    public static AffinityColor Affinity;

    public static void Reset()
    {
        CountRed = 0;
        CountGreen = 0;
        CountBlue = 0;
        Affinity = AffinityColor.None;
    }

    public static void CollectSphere(AffinityColor c)
    {
        Debug.Log("Collected " + c.ToString());
        switch (c)
        {
            case AffinityColor.Red:
                CountRed++;
                break;

            case AffinityColor.Blue:
                CountBlue++;
                break;

            case AffinityColor.Green:
                CountGreen++;
                break;
        }
    }

}
