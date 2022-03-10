using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    /* to create a functional door:
     * create an obj (door) with this script attached
     * apply the tag correlating to the scene it should lead to
     * done :D
     */

    private string doorTag;
    public Text doorLabel;
    public GameObject doorLabelGameObj;

    private void Awake()
    {
        doorTag = gameObject.tag;
        doorLabelGameObj = GameObject.FindGameObjectWithTag("LobbyUI");
        if (doorLabelGameObj != null)
        {
            doorLabel = doorLabelGameObj.GetComponent<Text>();
        }
    }
    private void OnMouseOver()
    {
        if (doorTag != "lobby")
        {
            doorLabel.text = doorTag;
        }
        if (Input.GetMouseButtonDown(0))
        {
            SceneChange();            
        }
    }

    private void OnMouseExit()
    {
        doorLabel.text = null;
    }

    public void SceneChange()
    {
        SceneManager.LoadScene(doorTag, LoadSceneMode.Single);
    }
}