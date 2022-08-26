using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Gamemng : MonoBehaviour
{
    public GameObject instantiatedObj;
    private GameObject spawnedPos;
    public Camera ARcamera;
    [SerializeField] int Thrownnum;
    [SerializeField] GameObject thrownMark;
    [SerializeField] Text thrownMarkNum;
    private List<RaycastResult> raycastResults = new List<RaycastResult>();
    // Start is called before the first frame update
    void Start()
    {
        Thrownnum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("works!");
            Ray ray = ARcamera.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray);

            if (IsPointOverUI(Input.mousePosition))
            {
                Debug.Log("nothing");
            }
            else
            {
                thrownMark.SetActive(true);
                Thrownnum++;
                thrownMarkNum.text = Thrownnum.ToString();

                spawnedPos = Instantiate(instantiatedObj, ray.origin, Quaternion.identity);
                spawnedPos.GetComponent<Rigidbody>().AddForce(ray.direction * 55);

            }
        }
    }


    private bool IsPointOverUI(Vector2 fingerPosition)
    {
        PointerEventData eventDataPosition = new PointerEventData(EventSystem.current);
        eventDataPosition.position = fingerPosition;
        EventSystem.current.RaycastAll(eventDataPosition, raycastResults);
        return raycastResults.Count > 0;
    }

}
