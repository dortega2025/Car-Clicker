using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;
using TMPro;
public class BonusScript : MonoBehaviour
{
    private int val = 0;
    private int cost = 100;
    private int[] increaseAmount = {1,2,4,8,16,32,64,128};
    GameObject increase;
    GameObject ppoints;
    public TMP_Text BonusCost;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        increase = GameObject.Find("systemManager");
        ppoints = GameObject.Find("systemManager");
        increase.GetComponent<systemManager>().increaseFactor = increaseAmount[0];
        BonusCost = GameObject.Find("Bonus Cost").GetComponent<TMP_Text>();
        BonusCost.text = "Cost: " + cost;
    }
    public void OnClick(){
        if(ppoints.GetComponent<systemManager>().points>=cost && val <= 7){
          val++;
        increase.GetComponent<systemManager>().increaseFactor = increaseAmount[val];  
         ppoints.GetComponent<systemManager>().points -= cost;
         cost = cost*2;
         BonusCost.text = "Cost: " + cost;
        }
        else{
            BonusCost.text = "Maxed Out!";
        }
    }
}
