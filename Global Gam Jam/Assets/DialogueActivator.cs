using UnityEngine;

public class DialogueActivator : MonoBehaviour, IInteractible
{

   [SerializeField] private DialogObject dialogObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out PlayerMovement player))
        {
            player.Interactible = this;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out PlayerMovement player))
        {
            if (player.Interactible is DialogueActivator dialogueActivator && dialogueActivator ==this)
            {
                player.Interactible= null;
            }
        }
    }

    public void Interact(PlayerMovement player)
    {
        player.DialogUI.ShowDialogue(dialogObject);
    }
}