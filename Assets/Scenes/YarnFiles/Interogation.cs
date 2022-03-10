using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Interogation : MonoBehaviour
{

    public InMemoryVariableStorage v;
    string ex;

    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        var suspect = v.TryGetValue("$suspect", out ex);

        Debug.Log(ex);

        if(ex == "dog")
        {
            spriteRenderer.sprite = spriteArray[0];
        }
        else if(ex == "squirrel"){

            spriteRenderer.sprite = spriteArray[1];

        }
        else if (ex == "squirrel")
        {

            spriteRenderer.sprite = spriteArray[2];

        }
        else
        {
            spriteRenderer.sprite = spriteArray[3];
        }



    }
}
