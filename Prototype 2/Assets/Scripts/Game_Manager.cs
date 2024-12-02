using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Game_Manager : MonoBehaviour
{
    private int _pointsCollected = 0;
    public TMP_Text gameOverText;
    public Button WinButton;

    public TMP_Text PointText;
    public int Points
    {
        get { return _pointsCollected; }
        set
        {
            _pointsCollected = value;
            Debug.LogFormat("Points: {0}", _pointsCollected);
            PointText.text = "Points: " + Points;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        gameOverText.gameObject.SetActive(true);
            WinButton.gameObject.SetActive(true);
            Time.timeScale = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
