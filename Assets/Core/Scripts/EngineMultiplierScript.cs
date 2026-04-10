using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;
using TMPro;
public class EngineMultiplierScript : MonoBehaviour
{
    private int  val = 0;
    private int cost = 50;
     private float[] engineMultiplier = {1.0f,1.2f,2.5f,4.0f,8.0f,16.0f,32.0f};
    GameObject player;
    GameObject ppoints;
    public TMP_Text EngineCost;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        //grab engineFactor from car
        player = GameObject.FindWithTag("Player");
        ppoints = GameObject.Find("systemManager");
        
        
        player.GetComponent<car>().engineFactor = engineMultiplier[0];
        EngineCost = GameObject.Find("Engine Cost").GetComponent<TMP_Text>();
        EngineCost.text = "Cost: " + cost;
        Debug.Log(engineMultiplier[0]);
        Debug.Log(player.GetComponent<car>().engineFactor);
        Debug.Log(val);
    }
    public void OnClick(){
        if(ppoints.GetComponent<systemManager>().points>=cost && val <=6){
            val++;
            player.GetComponent<car>().engineFactor = engineMultiplier[val];
            ppoints.GetComponent<systemManager>().points -= cost;
            cost = cost*2;
            Debug.Log(cost);
            EngineCost.text = "Cost: " + cost;
        }
        else{
            EngineCost.text = "Maxed Out!";
        }

        Debug.Log(val);
    }
}
