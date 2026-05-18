using UnityEngine;

public class DiscordManager : MonoBehaviour
{
    private DiscordRpc.EventHandlers handlers;

    void Start()
    {
        handlers = new DiscordRpc.EventHandlers();

        DiscordRpc.Initialize(
            "1505286371944694021",
            ref handlers,
            true,
            null
        );

        DiscordRpc.RichPresence presence = new DiscordRpc.RichPresence();
        
        presence.details = "Running from the ghost";
        presence.state = "Exploring the mansion";

        presence.largeImageKey = "183542-grimreaper";
        presence.largeImageText = "Ghost Horror";

        presence.smallImageKey = "ghost";
        presence.smallImageText = "Terrified";

        DiscordRpc.UpdatePresence(presence);
    }

    void Update()
    {
        DiscordRpc.RunCallbacks();
    }

    void OnApplicationQuit()
    {
        DiscordRpc.Shutdown();
    }
}