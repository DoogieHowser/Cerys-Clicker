using UnityEngine;
using System.Collections;

public class LovePerSec : MonoBehaviour
{
    public UnityEngine.UI.Text lpsDisplay;
    public Click click;
    public ItemManager[] items;


    void Start()
    {
        StartCoroutine(AutoLove());
    }

    public float GetLovePerSec()
    {
        float love = 0;
        foreach(ItemManager item in items)
        {
            love += item.count * item.lovePerSec;
        }
        return love;
    }

    public void AutoLovePerSec()
    {
        click.love += GetLovePerSec();
    }

    IEnumerator AutoLove()
    {
        while (true)
        {
            AutoLovePerSec();
            yield return new WaitForSeconds(1f);
        }

    }

    void Update()
    {
        lpsDisplay.text = GetLovePerSec() + " love/sec";
    }
}
