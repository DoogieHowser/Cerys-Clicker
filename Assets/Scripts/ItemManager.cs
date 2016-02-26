using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour
{
    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public float cost;
    public float lovePerSec;
    public int count = 0;
    public string itemName;

    private float baseCost;

    void Start()
    {
        baseCost = cost;
    }

    public void PurchaseItem()
    {
        if (click.love >= cost)
        {
            click.love -= cost;
            count += 1;
            cost = Mathf.Round(baseCost * Mathf.Pow (1.15f, count));
        }
    }

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\n Love: " + lovePerSec + "/s";
    }
}
