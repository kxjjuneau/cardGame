using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject playerArea;
    public GameObject cpuArea;
    void Start()
    {
        
    }

    public void OnClick()
    {
        Draw();
    }

    public void Draw()
    {
        GameObject pcard1 = Instantiate(card1, new Vector3(0,0,0), Quaternion.identity);
        pcard1.transform.SetParent(playerArea.transform, false);
        // GameObject ccard2 = Instantiate(card2, cpuArea.transform.position, Quaternion.identity);
        // card2.transform.SetParent(cpuArea.transform, false);
    }


}
