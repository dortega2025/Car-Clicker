using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;
using TMPro;
public class AeroSumScript : MonoBehaviour
{
    private float aeroSum = 0.0f;
    private int cost = 3;
    GameObject player;
    GameObject ppoints;
    public TMP_Text AeroCost;
    void Start()
    {
        ppoints = GameObject.Find("systemManager");
        player = GameObject.FindWithTag("Player");
        player.GetComponent<car>().aero = aeroSum; 
        AeroCost = GameObject.Find("Aero Cost").GetComponent<TMP_Text>();
        AeroCost.text = "Cost: " + cost;
    }

    // Update is called once per frame
    public void OnClick()
    {
        if(ppoints.GetComponent<systemManager>().points>=cost){
            aeroSum++;
            player.GetComponent<car>().aero = aeroSum;
            Debug.Log(aeroSum);
            ppoints.GetComponent<systemManager>().points -= cost;
            cost = cost*2;
            Debug.Log(cost);
            AeroCost.text = "Cost:\r\n" + cost;
            
    
        }
        
    }
}
