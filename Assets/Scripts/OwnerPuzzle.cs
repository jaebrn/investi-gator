using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OwnerPuzzle : MonoBehaviour
{
    public Sprite safe;
    public Sprite photos;
    private SpriteRenderer spriteRenderer;

    public bool puzzleComplete;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    private void Awake()
    {
        puzzleComplete = GameObject.Find("1").GetComponent<KeyCode>().isPuzzleComplete;
        if (puzzleComplete)
        {
            spriteRenderer.sprite = photos;
        }
        else
        {
            spriteRenderer.sprite = safe;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Keypad_Puzzle");
        }
    }
}
