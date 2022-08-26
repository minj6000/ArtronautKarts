using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManaging : MonoBehaviour
{
    public string SceneName;
    [SerializeField] GameObject loadPage;
    [SerializeField] bool loadPadeNeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneClick()
    {
        if (loadPadeNeed)
        {
            StartCoroutine(loading());
        }

        else
        {
            SceneManager.LoadScene(SceneName);
        }
    }
    IEnumerator loading()
    {
        loadPage.SetActive(true);
        yield return new WaitForSeconds(6.2f);
        SceneManager.LoadScene(SceneName);
    }

}
