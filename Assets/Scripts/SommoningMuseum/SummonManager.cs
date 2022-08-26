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
            relocationTxt.text = "����";
            InfoTxt.text = "ȭ���� ���� ���ð��� ��ȯ�ϼ���";
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
                relocationTxt.text = "�Ҹ�";
                
                InfoTxt.text = "�Ҹ��� ������ ���ð��� �������";
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

