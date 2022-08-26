using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SelectmarkerMove : MonoBehaviour
{
    [SerializeField] Transform MarkerTo;
    [SerializeField] GameObject Marker;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MenuBtn()
    {
        Marker.transform.DOMove(MarkerTo.transform.position, 1.5f);
    }
}
