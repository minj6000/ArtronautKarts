using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
public class SoundCollectCheck : MonoBehaviour
{
    public AudioSource currentlyPlaying;
    [SerializeField] TextMeshProUGUI CountCollection;
    public int collectCount = 0;
    public GameObject collectchoice;
    public CollectingEnable CollectingEnable;
    [SerializeField] Image collectnum;

    private void Update()
    {
        CollectingEnable = currentlyPlaying.gameObject.GetComponent<CollectingEnable>();


    }
    public void collect()
    {
        collectCount++;
        CountCollection.text = collectCount.ToString();
        collectchoice.SetActive(false);
        CollectingEnable.collected = true;
    }

    public void Delete()
    {
        currentlyPlaying.Stop();
        collectchoice.SetActive(false);
    }
}
