using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class ClickAndMoveBtn : MonoBehaviour
{
    bool Expanded;
    [SerializeField] GameObject PlanetSelectPanel;
    [SerializeField] GameObject ClosedPos;
    [SerializeField] GameObject OpenedPos;
    [SerializeField] GameObject wishinputParentPos;
    [SerializeField] GameObject WishInput;
    [SerializeField] GameObject wishinputBtn;
    [SerializeField] GameObject wishinputParent;
    public DataBaseManager DataBaseManager;
    // Start is called before the first frame update
    void Start()
    {
        Expanded =false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (Expanded)
        {
            PlanetSelectPanel.GetComponent<RectTransform>().DOMove(ClosedPos.transform.position, 2f);
            Expanded = false;
        }
        else if (!Expanded)
        {
            PlanetSelectPanel.GetComponent<RectTransform>().DOMove(OpenedPos.transform.position, 2f);
            wishinputParent.GetComponent<RectTransform>().DOMove(wishinputParentPos.transform.position, 2f);

            Expanded = true;
        }
    }

    public void OnWritten()
    {
        if(DataBaseManager.Mywish != "")
        {
            WishInput.gameObject.SetActive(false);
            wishinputBtn.SetActive(false);
            Expanded = true;
            PlanetSelectPanel.GetComponent<RectTransform>().DOMove(OpenedPos.transform.position, 2f);
            wishinputParent.GetComponent<RectTransform>().DOMove(wishinputParentPos.transform.position, 2f);
        }
        
    }

    public void PencilIconClicked()
    {
        if(wishinputBtn.activeSelf == true)
        {
            WishInput.gameObject.SetActive(false);
            wishinputBtn.SetActive(false);
        }
        else if(wishinputBtn.activeSelf == false)
        {
            WishInput.gameObject.SetActive(true);
            wishinputBtn.SetActive(true);
        }
    }
}
