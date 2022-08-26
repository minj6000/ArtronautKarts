using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class UImanager_ardrawing : MonoBehaviour
{
    [SerializeField] ARDrawManager ardrawManager;
    bool PlanetMode;
    bool DrawingMode;
    [SerializeField] GameObject drawingPanel;
    [SerializeField] GameObject stickerPanel;
    [SerializeField] GameObject tool;
    [SerializeField] Button btnforPlanet;
    [SerializeField] Button btnforDrawing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void modeSwitchforPlanet()
    {
        if (!PlanetMode)
        {
            btnforPlanet.GetComponent<Image>().DOFade(1, 2);
            btnforDrawing.GetComponent<Image>().DOFade(0.2f, 2);

            stickerPanel.gameObject.SetActive(true);
            drawingPanel.gameObject.SetActive(false);
            tool.SetActive(true);
            ardrawManager.enabled = false;
        }
    }   
    public void modeSwitchforDraw()
    {
        if (!DrawingMode)
        {
            btnforDrawing.GetComponent<Image>().DOFade(1, 2);
            btnforPlanet.GetComponent<Image>().DOFade(0.2f, 2);
            drawingPanel.gameObject.SetActive(true);
            stickerPanel.gameObject.SetActive(false);
            ardrawManager.enabled = true;
            tool.SetActive(false);


        }
    }
}
