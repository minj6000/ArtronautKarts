using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AstronautMovement : MonoBehaviour
{
    public Transform p1;
    public Transform p2;
    public Transform p3;

    private Vector3[] waypoints;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = new Vector3[3];
        waypoints.SetValue(p1.position, 0);
        waypoints.SetValue(p2.position, 1);
        waypoints.SetValue(p3.position, 2);

        transform.DOPath(waypoints, 15f, PathType.CatmullRom).SetEase(Ease.InOutQuad).SetLoops(-1, LoopType.Yoyo);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
