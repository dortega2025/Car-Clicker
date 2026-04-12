using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;
using TMPro;
public class TiresSumScript : MonoBehaviour
{
    private float TiresSum = 0.0f;
    private int val = 0;
    private int cost = 5;
    GameObject ppoints;
    GameObject player;
    public TMP_Text TireCost;
    void Start()
    {
      player = GameObject.FindWithTag("Player");
      ppoints = GameObject.Find("systemManager");
      player.GetComponent<car>().tires = TiresSum;  
      TireCost = GameObject.Find("Tires Cost").GetComponent<TMP_Text>();
      TireCost.text = "Cost: " + cost;
    }

    public void OnClick()
    {
        if(ppoints.GetComponent<systemManager>().points>=cost && val <= 5){
            val++;
            TiresSum += 2;
            player.GetComponent<car>().tires = TiresSum;
            ppoints.GetComponent<systemManager>().points -= cost;
            cost *= 2; 
            TireCost.text = "Cost: " + cost;
        } else if (val > 5) {
            TireCost.text = "Maxed Out!";
        }
    } 
}
