using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecodePuzzle : MonoBehaviour
{

    private InputField inputText;
    public Text t;

    // Start is called before the first frame update
    void Start()
    {
        inputText = GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputText.text == "chirpy von bird")
        {
            Debug.Log("You win");
            t.text = "This pill bottle belongs to Chirpy Bird! He might \n" +
                "He might've planted this here... ";
        }
        else if(inputText.text == "Chirpy Von Bird")
        {
            Debug.Log("You win");
            t.text = "This pill bottle belongs to Chirpy Bird! He might \n" +
               "He might've planted this here... ";
        }
        else
        {

        }

        
    }
}
