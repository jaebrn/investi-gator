using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        Button start = startButton.GetComponent<Button>(); // accessing start button
        start.onClick.AddListener(StartOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartOnClick()
    {
        SceneManager.LoadSceneAsync("Lobby"); // loads game scene on start button click
    }
}
