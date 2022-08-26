using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoloColorPick : MonoBehaviour
{
    public Color color;
    public float brushSize;
    [SerializeField]
    private LineSettings lineSettings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnColorPick()
    {
        color = this.GetComponent<Image>().color;
        lineSettings.endColor = color;
        lineSettings.startColor = color;
    }

    public void onBrushSizePick()
    {
        lineSettings.startWidth = brushSize;
        lineSettings.endWidth = brushSize;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
