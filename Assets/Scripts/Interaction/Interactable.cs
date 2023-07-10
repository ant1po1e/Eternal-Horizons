using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform interactionTransform;
    bool isFocus = false;
    bool isInteracted = false;
    Transform player;


    public virtual void Interact()
    {

    }

    void Update()
    {
        if (isFocus && !isInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);

            if (distance <= radius)
            {
                Interact();
                isInteracted = true;
            }
        }
    }

    public void OnFocused(Transform playerTransform)
    {
        isFocus= true;
        player = playerTransform;
        isInteracted = false;
    }

    public void NotFocused()
    {
        isFocus= false;
        player = null;
        isInteracted = false;
    }

    void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform;

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}
