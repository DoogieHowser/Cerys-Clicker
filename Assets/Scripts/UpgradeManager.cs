using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour
{
    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public float lovePower;
    public string itemName;

    private float baseCost;

    void Start()
    {
        baseCost = cost;
    }

    public void PurchaseUpgrade()
    {
        if (click.love >= cost)
        {
            click.love -= cost;
            count += 1;
            click.lovePerClick += lovePower;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));

        }
    }

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nLove: +" + lovePower;
    }

}
