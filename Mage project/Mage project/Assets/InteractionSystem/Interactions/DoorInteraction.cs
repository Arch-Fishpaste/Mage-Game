using DG.Tweening;
using UnityEngine;

<<<<<<< HEAD

public class DoorInteraction : MonoBehaviour, IInteractable
{
    [SerializeField] private Vector3 targetRotation = new Vector3(0, -100, 0);
    [SerializeField] private float rotationSpeed = 3f;

    private bool isOpen = false;


    public bool CanInteract()
    {
        return  true;
=======
public class DoorInteraction : MonoBehaviour, IInteractable 
{

    [SerializeField] private Vector3 targetRotation = new Vector3(0f, -100f, 0f);
    [SerializeField] private float rotationSpeed = 3f;
    private bool isOpen = false;









    public bool canInteract()
    {
        return true;
>>>>>>> ca6eb508b83a2abb1ba0d11eb9c3dc76cccd19e3
    }

    public bool Interact(Interactor interactor)
    {
<<<<<<< HEAD
        if(isOpen)
        {
            transform.DORotate(-targetRotation, rotationSpeed, RotateMode.WorldAxisAdd);
        }
    }

=======
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


>>>>>>> ca6eb508b83a2abb1ba0d11eb9c3dc76cccd19e3
}
