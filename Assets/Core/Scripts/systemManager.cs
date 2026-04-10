using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class systemManager : MonoBehaviour
{
    public int points;
    public int increaseFactor;
    public TMP_Text pointCnt;
    private bool isPaused;
    public GameObject paused;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = 0;
        increaseFactor = 1;
        pointCnt = GameObject.Find("points").GetComponent<TMP_Text>();
        paused = GameObject.Find("pauseMenu");
        paused.SetActive(false);
        pointCnt.text = "Points: " + points;
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        pointCnt.text = "Points: " + points;
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (!isPaused)
            {
                PauseGame();
            } else
            {
                ResumeGame();
            }
        }
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

    void PauseGame()
    {
        isPaused = true;
        paused.SetActive(true);
        Time.timeScale = 0f;
    }

    void ResumeGame()
    {
        isPaused = false;
        paused.SetActive(false);
        Time.timeScale = 1f;
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
