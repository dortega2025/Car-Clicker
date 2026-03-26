using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class systemManager : MonoBehaviour
{
    public int points;
    public int increaseFactor;
    public TMP_Text pointCnt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = 0;
        increaseFactor = 1;
        pointCnt = GameObject.Find("points").GetComponent<TMP_Text>();
        pointCnt.text = "Points: " + points;
    }

    // Update is called once per frame
    void Update()
    {
        pointCnt.text = "Points: " + points;
    }

    public void increasePoints()
    {
        points += increaseFactor;
    }

    public void spendPoints(int price)
    {
        if (price >= points)
        {
            points -= price;
        }
    }
}
