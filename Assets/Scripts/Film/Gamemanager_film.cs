using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Gamemanager_film : MonoBehaviour
{
    public GameObject instantiatedObj;
    private GameObject spawnedPos;
    public Camera ARcamera;
    private List<RaycastResult> raycastResults = new List<RaycastResult>();
    // Start is called before the first frame update
    void Start()
    {
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
                spawnedPos = Instantiate(instantiatedObj, ray.direction , Quaternion.identity);
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
