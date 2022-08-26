using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingEnable : MonoBehaviour
{
    public AudioSource audioToPlay;
    [SerializeField] GameObject CollectionChoice;
    [SerializeField] GameObject CollectBtn;
    [SerializeField] GameObject CancleBtn;
    public bool collected;
    // Start is called before the first frame update
    void Start()
    {
        collected=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundFound()
    {
        if (!collected)
        {
            CollectionChoice.SetActive(true);
            audioToPlay.Play();
            CollectBtn.GetComponent<SoundCollectCheck>().currentlyPlaying = audioToPlay;
            CancleBtn.GetComponent<SoundCollectCheck>().currentlyPlaying = audioToPlay;
             
            
        }
        else if (collected)
        {
            CollectionChoice.SetActive(false);

        }

    }

    public void SoundLost()
    {
        CollectionChoice.SetActive(false);

    }
}
