using UnityEngine;
using System.Collections.Generic;
public class AeroSumScript : MonoBehaviour
{
    private float aeroSum = 0.0f;
    GameObject player;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        player.GetComponent<car>().aero = aeroSum; 
    }

    // Update is called once per frame
    public void OnClick()
    {
        aeroSum++;
        player.GetComponent<car>().aero = aeroSum;
        Debug.Log(aeroSum);
    }
}
