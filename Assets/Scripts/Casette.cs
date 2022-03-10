using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Casette : MonoBehaviour
{
    public GameObject inventoryBar;
    public GameObject cassetteButton;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(cassetteButton, new Vector3(inventoryBar.transform.position.x + 25, inventoryBar.transform.position.y,0), Quaternion.identity);
            cassetteButton.transform.SetParent(inventoryBar.transform);
        }
    }
}
