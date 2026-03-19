using UnityEngine;
using System.Collections.Generic;
public class EngineMultiplierScript : MonoBehaviour
{
    private int  val = 0;
     private int Frame = 0;
    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        //grab engineFactor from car
        player = GameObject.FindWithTag("Player");
        Debug.Log(val);
    }
    public void OnClick(){
        val++;
        
        player.GetComponent<car>().engineFactor = Frame+val;

        Debug.Log(val);
    }
}
