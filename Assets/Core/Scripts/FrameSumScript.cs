using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;
using TMPro;
public class FrameSumScript : MonoBehaviour
{
    private float frameSum = 0.0f;
    private int cost = 8;
    GameObject player;
    GameObject ppoints;
    public TMP_Text FrameCost;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        ppoints = GameObject.Find("systemManager");
        player.GetComponent<car>().frame = frameSum;
        FrameCost = GameObject.Find("Frame Cost").GetComponent<TMP_Text>();
        FrameCost.text = "Cost: " + cost;
    }
    
    public void OnClick()
    {
        if(ppoints.GetComponent<systemManager>().points>=cost){
            frameSum++;
            player.GetComponent<car>().frame = frameSum;
            Debug.Log(frameSum);
            ppoints.GetComponent<systemManager>().points-=cost;
            cost = cost*2;
            FrameCost.text = "Cost: " + cost;
        }
        
    } 
}
