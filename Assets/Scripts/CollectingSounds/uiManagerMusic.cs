using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class uiManagerMusic : MonoBehaviour
{
    [SerializeField] GameObject tokenGet;
    [SerializeField] GameObject homeInfo;
    [SerializeField] GameObject missionInfo;
    [SerializeField] SoundCollectCheck soundcheck;
    bool tokenget;
    // Start is called before the first frame update
    void Start()
    {
        tokenget = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(soundcheck.collectCount > 1 && !tokenget)
        {
            tokenGet.SetActive(true);
        }

        if (tokenget)
        {
            
            homeInfo.SetActive(true);
        }
    }


    public void OnTokenClick()
    {
        tokenGet.transform.Find("Token").GetComponent<Image>().DOFade(0, 2);
        StartCoroutine(fadAndDeactive());

        IEnumerator fadAndDeactive()
        {
            yield return new WaitForSeconds(2f);
            tokenGet.SetActive(false);
            missionInfo.SetActive(false);
            tokenget = true;
        }
    }
}
