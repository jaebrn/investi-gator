using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeyCode : MonoBehaviour
{
    public static string keycode = "3356";
    public static string playerCode = "";

    public static int totalDigits = 0;

    public AudioSource audioSource;

    public Text textComponent;
    public GameObject uiObj;

    public bool isPuzzleComplete = false;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        uiObj = GameObject.FindGameObjectWithTag("LobbyUI");
        textComponent = uiObj.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (totalDigits == 4)
        {
            if (playerCode == keycode)
            {
                Debug.Log("win");
                isPuzzleComplete = true;
                textComponent.text = "CORRECT CODE";

                Invoke("SceneChange", 1);
            }
            else {

                playerCode = "";
                totalDigits = 0;
                Debug.Log("loser");
                textComponent.text = "INCORRECT CODE. TRY AGAIN";

            }
        }


    }
    
   
    private void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);

        if (Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
            playerCode += gameObject.name;
            totalDigits += 1;
            Debug.Log(playerCode);
        }
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
    }

    private void SceneChange()
    {
        SceneManager.LoadScene("Owner", LoadSceneMode.Single);
    }
}
