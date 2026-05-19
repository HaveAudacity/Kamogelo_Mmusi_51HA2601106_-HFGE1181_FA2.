using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public static PlayerInteraction instance;

    public GameObject interactUI;
    public Interactable currentInteractable;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentInteractable != null)
            {
                currentInteractable.Interact();
            }
        }
    }

    public void ShowUI(bool state)
    {
        interactUI.SetActive(state);
    }
}