using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleButton : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        Button thisButton = button.GetComponent<Button>(); // accessing start button

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartOnClick()
    {
        SceneManager.LoadSceneAsync("Lobby"); // loads game scene on start button click
    }

    public void ExitOnClick()
    {
        Application.Quit();
        Debug.Log("Game is Closing");
    }
}
