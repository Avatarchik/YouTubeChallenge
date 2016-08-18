using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {

    public string username = "hello";
    public string password = "5555";

    private string createAccountURL = "http://localhost/YouTubeUsers/CreateAccount.php";

    void Start()
    {
        StartCoroutine("CreateAccount");
    }

    IEnumerator CreateAccount()
    {
        WWWForm form = new WWWForm();
        form.AddField("Username", username);
        form.AddField("Password", password);
        WWW createAccountWWW = new WWW(createAccountURL, form);
        yield return createAccountWWW;
        if(createAccountWWW.error != null)
        {
            Debug.LogError("Could not connect to account creation");
        }
        else
        {
            string createAccountReturn = createAccountWWW.text;
            if (createAccountReturn == "Success")
            {
                Debug.Log("Success: account created");
            }
        }
    }




}
