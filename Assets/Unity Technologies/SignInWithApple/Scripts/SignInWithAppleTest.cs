using UnityEngine;
using UnityEngine.SignInWithApple;
using UnityEngine.UI;
using TMPro;

public class SignInWithAppleTest : MonoBehaviour
{
    public static SignInWithAppleTest _S;
    public TextMeshProUGUI userIdText;
    public TextMeshProUGUI displayName;
    public Text emailText;

    private void Awake()
    {
        _S = this;
    }
    public void Start()
    {
        gameObject.AddComponent<SignInWithApple>();
        Open();
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void ButtonPress()
    {
        var siwa = gameObject.GetComponent<SignInWithApple>();
        siwa.Login(OnLogin);
    }

    public void CredentialButton()
    {
        // User id that was obtained from the user signed into your app for the first time.
        var siwa = gameObject.GetComponent<SignInWithApple>();
        siwa.GetCredentialState("<userid>", OnCredentialState);
    }

    private void OnCredentialState(SignInWithApple.CallbackArgs args)
    {
        Debug.Log("User credential state is: " + args.credentialState);
    }

    private void OnLogin(SignInWithApple.CallbackArgs args)
    {
        Debug.Log("Sign in with Apple login has completed.");
    }
}
