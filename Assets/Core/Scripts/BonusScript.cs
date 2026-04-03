using UnityEngine;
using System.Collections.Generic;
public class BonusScript : MonoBehaviour
{
    private int val = 0;
    private int[] increaseAmount = {1,2,4,8,16,32,64,128};
    GameObject increase;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        increase = GameObject.Find("systemManager");
        increase.GetComponent<systemManager>().increaseFactor = increaseAmount[0];

    }
    public void OnClick(){
        val++;
        increase.GetComponent<systemManager>().increaseFactor = increaseAmount[val];
    }
}
