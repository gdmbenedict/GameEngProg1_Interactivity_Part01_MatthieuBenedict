using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    List<InteractableObject> interactableObjects = new List<InteractableObject>();

    [Header("Interaction settings")]
    [SerializeField] private KeyCode interactButton;
    [SerializeField] private float messageDistanceFromPlayer =1f;
    [SerializeField] private float messageSpaceing =0.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //handle button presses
        if (Input.GetKeyDown(interactButton) && interactableObjects.Count > 0)
        {
            InteractableObject interact = interactableObjects.First();
            interact.Interact();
        }
    }

    private void OnTriggerEnter2D(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            interactableObjects.Add(other.gameObject.GetComponent<InteractableObject>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            interactableObjects.Remove(other.gameObject.GetComponent<InteractableObject>());
        }

    }

    IEnumerator Message()
    {

    }

}
