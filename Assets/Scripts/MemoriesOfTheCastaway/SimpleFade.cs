using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SimpleFade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().DOFade(1, 10f).SetDelay(3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
