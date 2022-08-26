using Firebase.Database;
using System.Collections;
using TMPro;
using UnityEngine;

public class DataBaseManager : MonoBehaviour
{
    public TMP_InputField WishInput;
    //public TextMeshProUGUI wishTxt;
    public string userID;
    private DatabaseReference dbReference;

    public GameObject[] Otherstmplist;
    public string Mywish;

    int i;
    // Start is called before the first frame update
    void Start()
    {
        Otherstmplist = GameObject.FindGameObjectsWithTag("WishesOfOthers");
        userID = SystemInfo.deviceUniqueIdentifier;
        dbReference = FirebaseDatabase.DefaultInstance.RootReference;
        GetWishes();
    }

    public void CreatWishes()
    {
        User newUser = new User(WishInput.text);
        string json = JsonUtility.ToJson(newUser);
        Mywish = WishInput.text;
        i = Random.Range(1, 70);
        dbReference.Child("User" + i).SetRawJsonValueAsync(json);
    }

    public IEnumerator LoadWishes()
    {
        for (int d = 0; d < Otherstmplist.Length; d++)
        {
            i = Random.Range(1, 70);
            var wishData = dbReference.Child("User" + i).Child("Wish").GetValueAsync();
            yield return new WaitUntil(predicate: () => wishData.IsCompleted);
            if (wishData.Exception != null)
            {
                Debug.Log("Fail to fetch");
            }

            else if (wishData.Result.Value == null)
            {
                Debug.Log("No data yet");
            }

            else
            {
                DataSnapshot snapshot = wishData.Result;
                Debug.Log("user " + i + " value:  " + snapshot.Value.ToString());
                Otherstmplist[d].GetComponent<TextMeshPro>().text = snapshot.Value.ToString();
            }
        }

    }
    public void GetWishes()
    {
        StartCoroutine(LoadWishes());
    }

}
