using DG.Tweening;
using UnityEngine;


public class DoorInteraction : MonoBehaviour, IInteractable
{
    [SerializeField] private Vector3 targetRotation = new Vector3(0, -100, 0);
    [SerializeField] private float rotationSpeed = 3f;

    private bool isOpen = false;


    public bool CanInteract()
    {
        return  true;
    }

    public bool Interact(Interactor interactor)
    {
        if(isOpen)
        {
            transform.DORotate(-targetRotation, rotationSpeed, RotateMode.WorldAxisAdd);
        }
    }

}
