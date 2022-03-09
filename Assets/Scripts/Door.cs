using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    /* to create a functional door:
     * create an obj (door) with this script attached
     * apply the tag correlating to the scene it should lead to
     * done :D
     */

    private string doorTag;

    private void Awake()
    {
        doorTag = gameObject.tag;
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(doorTag, LoadSceneMode.Single);            
        }
    }
}