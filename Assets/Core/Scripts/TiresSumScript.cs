using UnityEngine;
using System.Collections.Generic;
public class TiresSumScript : MonoBehaviour
{
    private float TiresSum = 0.0f;
    GameObject player;
    void Start()
    {
      player = GameObject.FindWithTag("Player");
      player.GetComponent<car>().tires = TiresSum;  
    }

    public void OnClick()
    {
        TiresSum++;
        
        player.GetComponent<car>().tires = TiresSum;

        Debug.Log(TiresSum);
    } 
}
