using UnityEngine;

public class LinkRedirect : MonoBehaviour
{
    [SerializeField]
    private string targetUrl = "https://github.com/Fmasterpro27/NTX-Rpc";

    public void OpenLink()
    {
        if (string.IsNullOrWhiteSpace(targetUrl))
        {
            Debug.LogWarning("Target URL is empty!");
            return;
        }

        Application.OpenURL(targetUrl);
    }
}