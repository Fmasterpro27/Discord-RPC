using UnityEngine;
#if DISCORD_SOCIAL_SDK_EXISTS
using Discord.Sdk;
#endif

/// <summary>
/// RichPresence manages the Discord Rich Presence for the game. You can set game details, state, time played, and more!
/// 
/// https://discord.com/developers/docs/discord-social-sdk/development-guides/setting-rich-presence
/// </summary>
public class RichPresence : MonoBehaviour
{
    public static RichPresence Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.Log($"Duplicate RichPresence destroyed: {gameObject.name}");
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        Debug.Log($"RichPresence Singleton initialized on: {gameObject.name} | ID: {GetEntityId()}");
    }
#pragma warning disable 0414
    [SerializeField] private ulong applicationId = 1505286371944694021;
    [SerializeField] private string startState = "Managing Rich Presence";
    [SerializeField] private string startDetails = "Using NTX RPC";
    [SerializeField] private string largeImageText = "NTX RPC";
    [SerializeField] private string largeImageKey = "ntx-logo-white";
    [SerializeField] private string smallImageText = "v0.1.0-Alpha";
    [SerializeField] private string smallImageKey = "connected";
    [SerializeField] private string setlabel = "View on GitHub";
    [SerializeField] private string seturl = "https://github.com/Fmasterpro27/NTX-Rpc";
#pragma warning restore 0414

#if DISCORD_SOCIAL_SDK_EXISTS
    private Client client;
    private ulong startTimestamp;

    void Start()
    {
        // StartRPC(); // Call this manually if you want the RPC to start on button click, or uncomment to start automatically.
    }

    public void StartRPC()
    {
        if (client != null)
            return;

        client = new Client();
        client.SetApplicationId(applicationId);
        client.Connect();

        startTimestamp = (ulong)System.DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        UpdateRichPresence(ActivityTypes.Playing, startState, startDetails);
    }

    public void StopRichPresence()
    {
        if (client == null)
        {
            Debug.LogWarning("StopRichPresence called but client is null — was StartRPC() ever called?");
            return;
        }

        client.ClearRichPresence();
        var c = client;
        client = null;
        c.Disconnect();
        startTimestamp = 0; // reset timestamp too
        Debug.Log("RPC stopped.");
    }

    public void UpdateRichPresence(ActivityTypes type, string state, string details)
    {
        if (client == null)
        {
            Debug.LogWarning("Cannot update RPC because client is null.");
            return;
        }

        Activity activity = new Activity();

        activity.SetType(type);
        activity.SetState(state);
        activity.SetDetails(details);

        ActivityAssets assets = new ActivityAssets();
        assets.SetLargeImage(largeImageKey);
        assets.SetLargeText(largeImageText);
        assets.SetSmallImage(smallImageKey);
        assets.SetSmallText(smallImageText);
        activity.SetAssets(assets);

        ActivityTimestamps activityTimestamp = new ActivityTimestamps();
        activityTimestamp.SetStart(startTimestamp);
        activity.SetTimestamps(activityTimestamp);

        ActivityButton button = new ActivityButton();
        button.SetLabel(setlabel);
        button.SetUrl(seturl);
        activity.AddButton(button);

        client.UpdateRichPresence(activity, OnUpdateRichPresence);
    }

    public void SetDefaultRichPresence()
    {
        UpdateRichPresence(ActivityTypes.Playing, startState, startDetails);
    }

    private void OnUpdateRichPresence(ClientResult result)
    {
        if (result.Successful())
        {
            Debug.Log("Rich presence updated!");
        }
        else
        {
            Debug.LogError($"Failed to update rich presence: {result.Error()}");
        }
    }

    private void OnDestroy()
    {
        if (client != null)
        {
            client.Disconnect();
            client = null;
        }
    }
#endif
}