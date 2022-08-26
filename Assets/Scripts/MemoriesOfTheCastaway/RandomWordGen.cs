using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
public class RandomWordGen : MonoBehaviour
{
    [SerializeField] Uifadeinout uifade;
    [SerializeField] TokenCheck tokencheck;
    [SerializeField] TextMeshPro textPaste;
    public bool Selected;
    List<NameSave> namess = new List<NameSave>();
    public TextMeshPro text;
    public TextAsset WordsData;
    private NameSave n;
    string[] data;
    public string selectedWord;
    [SerializeField] GameObject Hands;
    // Start is called before the first frame update
    void Start()
    {
        Selected = false;
        System.Random random = new System.Random();
        int number = random.Next(1, 11);
        data = WordsData.text.Split(new char[] { '\n' });
        List<string> names = new List<string>();
        string[] row = data[number].Split(new char[] { ',' });
        n = new NameSave();
        n.RandomName = row[0];
        namess.Add(n);

        StartCoroutine(wordsRotate());

    }


    IEnumerator wordsRotate()
    {
        for(int i = 0; i < 100; i++)
        {
            if (!Selected)
            {
                text.text = data[i];
                if(text.text == data[10])
                {
                    i = 0;
                }
                yield return new WaitForSeconds(0.2f);
                
            }
            else
            {
                selectedWord = data[Random.Range(0, data.Length)];
                text.text = selectedWord;
                textPaste.text = selectedWord + "\n...?" +" \n이건, 설마...?";
                uifade.TokenIn();
                textPaste.gameObject.SetActive(true);
                
            }
        }

    }

    public void BtnClick()
    {
        Debug.Log("clicked");

        Hands.gameObject.SetActive(false);
        Selected = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
