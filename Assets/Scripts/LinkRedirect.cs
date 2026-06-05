using UnityEngine;

public class LinkRedirect : MonoBehaviour
{
    [Header("External Links")]
    [SerializeField] private string githubUrl =
        "https://github.com/Fmasterpro27/NTX-Rpc";

    [SerializeField] private string privacyUrl =
        "https://ntx-rpc.markmazi4030mgaming70.workers.dev/privacy";

    [SerializeField] private string termsUrl =
        "https://ntx-rpc.markmazi4030mgaming70.workers.dev/terms";

    [SerializeField] private string brandingUrl =
        "https://ntx-rpc.markmazi4030mgaming70.workers.dev/branding";

    [SerializeField] private string licenseUrl =
        "https://ntx-rpc.markmazi4030mgaming70.workers.dev/Licenses";

    public void OpenGithub()
    {
        Application.OpenURL(githubUrl);
    }

    public void OpenPrivacy()
    {
        Application.OpenURL(privacyUrl);
    }

    public void OpenTerms()
    {
        Application.OpenURL(termsUrl);
    }

    public void OpenBranding()
    {
        Application.OpenURL(brandingUrl);
    }

    public void OpenLicense()
    {
        Application.OpenURL(licenseUrl);
    }
}