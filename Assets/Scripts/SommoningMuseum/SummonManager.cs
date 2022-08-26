using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class SummonManager : MonoBehaviour
{
    public Button relocationbtn;
    public Text relocationTxt;
    public Text InfoTxt;
    public Camera ARcamera;
    public GameObject spawnedobj;
    private GameObject instantiatedobj;
    private bool spawned = false;

    private List<RaycastResult> raycastResults = new List<RaycastResult>();
    // Start is called before the first frame update
    void Awake()
    {
        relocationbtn.onClick.AddListener(relocation);
    }


    // Update is called once per frame

    void relocation()
    {
        if (spawned)
        {
            Destroy(instantiatedobj);
            spawned = false;
            relocationTxt.text = "생성";
            InfoTxt.text = "화면을 눌러 전시관을 소환하세요";
        }
    }

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

            if (!spawned)
            {
                instantiatedobj = Instantiate(spawnedobj, ray.origin, Quaternion.identity);
                spawned = true;
                relocationTxt.text = "소멸";
                
                InfoTxt.text = "소멸을 누르면 전시관이 사라져요";
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

