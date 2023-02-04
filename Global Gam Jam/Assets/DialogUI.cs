using UnityEngine;
using TMPro;
using System.Collections;


public class DialogUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogObject testDialogue;
    [SerializeField] private GameObject dialogueBox;
    
    private TypewritterEffect typewritterEffect;

    private void Start()
    {
       // textLabel.text = "Hello!\n This is my new line.";
      // GetComponent<TypewritterEffect>().Run("Hellajhbfiluafiyugflo!\n This is maefahifuhay new line.", textLabel);
        typewritterEffect =GetComponent<TypewritterEffect>();
        CloseDialogueBox();
        ShowDialogue(testDialogue);
        
    
    
    }

    public void ShowDialogue(DialogObject dialogueObject)
    {
        dialogueBox.SetActive(true);
        StartCoroutine(StepThroughDialouge(dialogueObject));
    }

    private IEnumerator StepThroughDialouge(DialogObject dialogueObject)
    {
        //yield return new WaitForSeconds(2);

        foreach (string dialogue in dialogueObject.Dialogue)
        {
            yield return typewritterEffect.Run(dialogue, textLabel);
            yield return new WaitUntil(()=> Input.GetKeyDown(KeyCode.Space));

        }
        CloseDialogueBox();
    }

    private void CloseDialogueBox(){
        dialogueBox.SetActive(false);
        textLabel.text=string.Empty;
    }
}
