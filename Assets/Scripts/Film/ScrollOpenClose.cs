using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class ScrollOpenClose : MonoBehaviour
{
    [SerializeField] GameObject DecoScroll;
    [SerializeField] GameObject FilterScroll;
    [SerializeField] Transform DecoOpenPos;
    [SerializeField] Transform DecoClosePos;
    [SerializeField] Transform FilterOpenPos;
    [SerializeField] Transform FilterClosePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecoOpenClose()
    {
        if(DecoScroll.transform.position == DecoOpenPos.position)
        {
            DecoScroll.transform.DOMove(DecoClosePos.position, 2f);
        }
        else if(DecoScroll.transform.position == DecoClosePos.position)
        {
            DecoScroll.transform.DOMove(DecoOpenPos.position, 2f);

        }
    }    
    public void FilterOpenClose()
    {
        if (FilterScroll.transform.position == FilterOpenPos.position)
        {
            FilterScroll.transform.DOMove(FilterClosePos.position, 2f);
        }
        else if (FilterScroll.transform.position == FilterClosePos.position)
        {
            FilterScroll.transform.DOMove(FilterOpenPos.position, 2f);

        }
    }

    public void SceneChange(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
