using UnityEngine;
using System.Collections.Generic;
public class FrameSumScript : MonoBehaviour
{
    private float frameSum = 0.0f;
    GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        player.GetComponent<car>().frame = frameSum;
    }
    
    public void OnClick()
    {
        frameSum++;
        
        player.GetComponent<car>().frame = frameSum;

        Debug.Log(frameSum);
    } 
}
