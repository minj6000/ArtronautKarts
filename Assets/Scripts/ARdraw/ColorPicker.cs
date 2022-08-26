using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorPicker : MonoBehaviour
{
    public Color color;
    Vector2 mouseClickedPos;
    RectTransform Rect;
    Texture2D ColorTexture;
    [SerializeField]
    private LineSettings lineSettings;

    bool over;
    // Start is called before the first frame update
    void Start()
    {
        over = false;
        Rect = GetComponent<RectTransform>();
        ColorTexture = GetComponent<Image>().mainTexture as Texture2D;
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(over);
        if (Input.GetMouseButtonDown(0))
        {
            mouseClickedPos = Input.mousePosition;
        }
            
        Vector2 delta;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(Rect, mouseClickedPos, null, out delta);

        string debug = "mouseposition=" + Input.mousePosition;
        debug += "<br>delta=" + delta;

        float width = Rect.rect.width;
        float height = Rect.rect.height;
        delta += new Vector2(width * .5f, height * .5f);
        debug += "<br>offset delta=" + delta;

        float x = Mathf.Clamp(delta.x / width, 0f, 1f);
        float y = Mathf.Clamp(delta.x / height, 0f, 1f);
        debug += "<br>x=" + x + "y=" +y;

        int texX = Mathf.RoundToInt(x * ColorTexture.width);
        int texY = Mathf.RoundToInt(x * ColorTexture.height);
        debug += "<br>texx=" + texX + "texy=" + texY;

        color = ColorTexture.GetPixel(texX, texY);
        lineSettings.endColor = color;
        lineSettings.startColor = color;


    }
}
