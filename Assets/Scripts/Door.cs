using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Kitchen", LoadSceneMode.Single);
        }
    }
}
