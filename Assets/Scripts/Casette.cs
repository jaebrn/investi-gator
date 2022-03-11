using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Casette : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(playAudioSequentially());
        }
    }

    IEnumerator playAudioSequentially()
    {
        yield return null;

        for(int i = 0; i<audioClips.Length; i++)
        {
            if(i == 0 || i == 1)
            {
                audioSource.pitch = 1.2f;
            }else if(i == 2)
            {
                audioSource.pitch = 1.4f;
            }
            else
            {
                audioSource.pitch = 1.5f;
            }
            
            audioSource.clip = audioClips[i];
            audioSource.Play();
            print("playing");
            print(i);

            while (audioSource.isPlaying)
            {
                yield return null;
            }

        }
    }
}
