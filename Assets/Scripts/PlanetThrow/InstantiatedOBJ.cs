using TMPro;
using UnityEngine;

public class InstantiatedOBJ : MonoBehaviour
{
    public Gamemng manager;
    public GameObject instantiate;
    private GameObject instantiatetxt;
    [SerializeField] DataBaseManager dbm;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Onclick()
    {
        manager.instantiatedObj = instantiate.gameObject;
        instantiatetxt = instantiate.gameObject.transform.GetChild(0).gameObject;
        instantiatetxt.GetComponent<TextMeshPro>().text = dbm.Mywish;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
