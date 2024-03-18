using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public enum InteractionType
    {
        pickup,
        info
    }

    [Header("Interaction Data")]
    public InteractionType interactionType;
    public string name = null;
    public string message;
    public bool hasPrompt = true;

    [Header("Interaction Prompt")]
    [SerializeField] private TextMeshPro prompt;
    [SerializeField] private float fontSize = 6f;
    [SerializeField] private Color textColor = Color.white;
    [SerializeField] private TextAlignmentOptions alignmentOptions = TextAlignmentOptions.Center;


    private void Awake()
    {
        prompt = GetComponent<TextMeshPro>();

        if (hasPrompt)
        {
            //set prompt settings
            prompt.fontSize = fontSize;
            prompt.color = textColor;
            prompt.alignment = alignmentOptions;

            prompt.enabled = false;
        }
        else
        {
            prompt.enabled = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //sets and activates prompt on interactable
    public void ShowPrompt(string prompt)
    {
        if (hasPrompt)
        {
            this.prompt.text = prompt;
            this.prompt.enabled = true;
        }
        
    }

    public void HidePrompt()
    {
        prompt.enabled = false;
    }

    public string Interact()
    {
        string message = null;

        switch (interactionType)
        {
            case InteractionType.pickup:

                message = "Picked up " + name; //ma
                DelayedDestroy();
                break;

            case InteractionType.info:
                message = this.message;
                break;
        }

        return message;
    }

    IEnumerator DelayedDestroy()
    {
        yield return null;
        Destroy(gameObject);
    }

    

    
}
