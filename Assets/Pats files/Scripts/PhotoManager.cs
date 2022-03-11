using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoManager : MonoBehaviour
{
    public GameObject photo1;
    public GameObject photo2;
    public GameObject photo3;
    public GameObject photo4;

    public Text t;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {

        if (photo1.GetComponent<PhotoPuzzle>().correct && photo2.GetComponent<PhotoPuzzle>().correct && photo3.GetComponent<PhotoPuzzle>().correct &&
            photo4.GetComponent<PhotoPuzzle>().correct)
        {
            t.text = "So that Dog was cheating on his wife with a foxy fox. Interesting...";
           
        }
        

        





        

    }
}
