using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class SwipeDetection : MonoBehaviour
{
    private bool TouchEnded =false;
    private Vector2 startTouchPos;
    private Vector2 CurrentTouchPos;
    private Vector2 EndTouchPos;
    [SerializeField] Text txt;
    public float SwipeRange;
    public float TapRange;
    [SerializeField] GameObject box;

    // Update is called once per frame
    void Update()
    {
        Swipe();
    }

    public void Swipe()
    {
        if(Input.touchCount >0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPos = Input.GetTouch(0).position;
        }
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            CurrentTouchPos = Input.GetTouch(0).position;
            Vector2 Dist = CurrentTouchPos - startTouchPos;

            if (!TouchEnded)
            {
                if(Dist.x < -SwipeRange)
                {
                    txt.text = "left";
                    box.transform.DOMove(new Vector3(this.transform.position.x - 4f, this.transform.position.y, this.transform.position.z), 3f);
                    TouchEnded = true;
                    Debug.Log("left");
                }
                else if (Dist.x > SwipeRange)
                {
                    txt.text = "right";
                    box.transform.DOMove(new Vector3(this.transform.position.x + 4f, this.transform.position.y, this.transform.position.z), 3f);
                    TouchEnded = true;
                    Debug.Log("right");
                }
                else if (Dist.y > SwipeRange)
                {
                    txt.text = "up";
                    box.transform.DOMove(new Vector3(this.transform.position.x, this.transform.position.y + 4f, this.transform.position.z), 3f);
                    TouchEnded = true;
                    Debug.Log("up");
                }
                else if (Dist.y < -SwipeRange)
                {
                    txt.text = "down";
                    box.transform.DOMove(new Vector3(this.transform.position.x, this.transform.position.y - 4f, this.transform.position.z), 3f);
                    TouchEnded = true;
                    Debug.Log("down");
                }
            }
        }
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            TouchEnded = false;
            EndTouchPos = Input.GetTouch(0).position;
            box.transform.DOMove(new Vector3(0, 0.52f, 5.9f),3f);
            Vector2 dist = EndTouchPos - startTouchPos;
            if(Mathf.Abs(dist.x) < TapRange && Mathf.Abs(dist.y) > TapRange)
            {
                txt.text = "tap";
            }
        }

    }
}
