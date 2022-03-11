using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCode : MonoBehaviour
{
    public static string keycode = "3356";
    public static string playerCode = "";

    public static int totalDigits = 0;

    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (totalDigits == 4)
        {
            if (playerCode == keycode)
            {
                Debug.Log("win");
            }
            else {

                playerCode = "";
                totalDigits = 0;
                Debug.Log("loser");

            }
        }


    }
       
    private void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);

        if (Input.GetMouseButtonDown(0))
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }
            playerCode += gameObject.name;
            totalDigits += 1;
            Debug.Log(playerCode);
        }
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
    }

}
