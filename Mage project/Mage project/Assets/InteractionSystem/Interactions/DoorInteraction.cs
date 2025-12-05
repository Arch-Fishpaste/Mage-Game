using DG.Tweening;
using UnityEngine;

public class DoorInteraction : MonoBehaviour, IInteractable 
{

    [SerializeField] private Vector3 targetRotation = new Vector3(0f, -100f, 0f);
    [SerializeField] private float rotationSpeed = 3f;
    private bool isOpen = false;









    public bool canInteract()
    {
        return true;
    }

    public bool Interact(Interactor interactor)
    {
        if (isOpen)
        {
            transform.DORotate(-targetRotation, rotationSpeed, RotateMode.WorldAxisAdd);

        }
        else
        {
            transform.DORotate(targetRotation, rotationSpeed, RotateMode.WorldAxisAdd);
        }

        isOpen = !isOpen;
        
        return true;
    }


}
