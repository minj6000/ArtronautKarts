using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class Uifadeinout : MonoBehaviour
{
    [SerializeField] GameObject token;
    [SerializeField] GameObject tokenbtn;
    [SerializeField] TokenCheck tokencheck;
    [SerializeField] GameObject PilotMessage;
    [SerializeField] GameObject GobackTxt;
    private void Start()
    {
        FadeinInOut();   
    }

    public void FadeinInOut()
    {
        StartCoroutine(fade());
        IEnumerator fade()
        {
            PilotMessage.GetComponent<Image>().DOFade(1, 2);
            yield return new WaitForSeconds(1f);
            PilotMessage.GetComponent<Image>().DOFade(0.5f, 1);
            yield return new WaitForSeconds(1f);
            PilotMessage.GetComponent<Image>().DOFade(1, 1);
            yield return new WaitForSeconds(4f);
            PilotMessage.GetComponent<Image>().DOFade(0, 2);
        }
    }

    public void TokenIn()
    {
        Sequence mySequence = DOTween.Sequence();
        token.gameObject.SetActive(true);
        mySequence.Append(token.transform.DOScale(new Vector3(1, 1, 1), 3f).OnComplete(_tokenbtn));
    }

    public void _tokenbtn()
    {
        tokenbtn.gameObject.SetActive(true);
    }

    public void TokenGet()
    {
        tokencheck._TheaterToken = true;
        token.gameObject.SetActive(false);
        GobackTxt.gameObject.SetActive(true);
        GobackTxt.transform.DOScale(new Vector3(1.15f, 1.15f, 1.15f), 3f).SetLoops(-1);
    }


}
