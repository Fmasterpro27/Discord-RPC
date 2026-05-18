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
#pragma warning disable 0414
    [SerializeField] private ulong applicationId = 1505286371944694021;
    [SerializeField] private string startState = "Exploring the mansion";
    [SerializeField] private string startDetails = "Running from the ghost";
    [SerializeField] private string largeImageKey = "183542-grimreaper";
    [SerializeField] private string largeImageText = "Ghost Horror";
    [SerializeField] private string smallImageKey = "ghost";
    [SerializeField] private string smallImageText = "Terrified";
#pragma warning restore 0414

#if DISCORD_SOCIAL_SDK_EXISTS
    private Client client;
    private ulong startTimestamp;

    void Start()
    {
        client = new Client();
        client.SetApplicationId(applicationId);

        // ✅ Use seconds (not milliseconds) for Discord timestamps
        startTimestamp = (ulong)System.DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        UpdateRichPresence(ActivityTypes.Playing, startState, startDetails);
    }

    // ✅ No Update() needed — Discord Social SDK is event-driven, not polling-based

    public void UpdateRichPresence(ActivityTypes type, string state, string details)
    {
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