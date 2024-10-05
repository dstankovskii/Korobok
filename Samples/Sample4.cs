using UnityEngine;
// ...

// The next piece of code might be useful for many game developers. In Unity, when switching from one scene to another,
// all objects in the current scene are destroyed. Without the following code, it is impossible to have continuous music play throughout the game:

// A script is created and then attached
// to the object playing the music
public class DontDestroy : MonoBehaviour
{
    private AudioSource audioManager;
    public static bool flagPause = false;
    // ...
    
    public void Awake()
    {
        audioManager = GetComponent<AudioSource>();
        // Mark this object so that it is not destroyed
        DontDestroyOnLoad(this);
        // But sometimes a duplicate audio object appears when switching to a new scene,
        // so we destroy the extra one
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        // The last created object is destroyed, so the music will not restart
    }
}
