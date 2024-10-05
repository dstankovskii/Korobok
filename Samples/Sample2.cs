using UnityEngine;
// ...

// Another problem related to isometry implementation is the order of displaying objects on the field. 
// It should seem that the objects positioned lower on the field are closer to the player, 
// and thus should be displayed on top of those that are positioned higher. The solution is fairly simple.

// A separate script is created and then attached to all game objects on the field
public class ZIndex : MonoBehaviour
{
    void Update()
    {
        // The z coordinate of the object should depend on y, 
        // or you can simply equate them, and Unity will automatically draw the object 
        // closer on the z-axis on top of others.
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
    }
}
