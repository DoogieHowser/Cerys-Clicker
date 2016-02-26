using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour
{
    public UnityEngine.UI.Text scoreDisplay;
    public UnityEngine.UI.Text lpc;
    public float love = 0.00f;
    public float lovePerClick = 1;

    public void Clicked()
    {
        love += lovePerClick;
    }

    void Update()
    {
        scoreDisplay.text = "Gold: " + love;
        lpc.text = lovePerClick + " love/click";
    }
}
