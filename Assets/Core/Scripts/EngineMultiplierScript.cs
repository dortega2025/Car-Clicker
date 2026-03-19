using UnityEngine;
using System.Collections.Generic;
public class EngineMultiplierScript : MonoBehaviour
{
    private int  val = 0;
     private float[] engineMultiplier = {1.0f,1.2f,2.5f,4.0f,8.0f,16.0f,32.0f};
    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        //grab engineFactor from car
        player = GameObject.FindWithTag("Player");
        
        
        player.GetComponent<car>().engineFactor = engineMultiplier[0];
        Debug.Log(engineMultiplier[0]);
        Debug.Log(player.GetComponent<car>().engineFactor);
        Debug.Log(val);
    }
    public void OnClick(){
        val++;
        
        player.GetComponent<car>().engineFactor = engineMultiplier[val];

        Debug.Log(val);
    }
}
