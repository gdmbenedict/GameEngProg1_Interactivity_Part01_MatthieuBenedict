using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public enum InteractionType
    {
        pickup,
        info
    }

    public InteractionType interactionType;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPrompt(string prompt)
    {

    }

    public void HidePrompt()
    {

    }

    public void Interact()
    {
        switch (interactionType)
        {
            case InteractionType.pickup:
                break;

            case InteractionType.info:
                break;
        }
    }

    

    
}
