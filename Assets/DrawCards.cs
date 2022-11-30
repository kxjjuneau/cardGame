using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public List<GameObject > playerDeck = new List<GameObject >();
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
        // get random card from deck
        int randomCard = Random.Range(0, playerDeck.Count);
        GameObject pcard1 = Instantiate(playerDeck[randomCard], new Vector3(0,0,0), Quaternion.identity);
        pcard1.transform.SetParent(playerArea.transform, false);
        // GameObject ccard2 = Instantiate(card2, cpuArea.transform.position, Quaternion.identity);
        // card2.transform.SetParent(cpuArea.transform, false);
    }


}
