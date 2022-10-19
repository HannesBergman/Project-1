using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrashPickup : MonoBehaviour
{
  //  public PlayerInput InputScript;     // Change PlayerInput with name of input script
  //  public SpawnManager spawnManager;       // and then add TrashRemoveActionInput = Whatever the input is (eg. Input.GetKeyDow(KeyCode.Mouse0); ) 

    void Update()
    {
        var closestTrash = GetClosestTrash();
        if (closestTrash == null) return;
       /* if () //Replace Input.GetKeyDow(KeyCode.Mouse0) with InputScript.NameOfTheFunction
        {
            var interactable = closestTrash.GetComponent<IInteractable>();
            if (interactable == null) return;
            interactable.Interact();
            
        }*/
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "trash")
        {
            var interactable = collider.GetComponent<IInteractable>();
            if (interactable == null) return;
            interactable.Interact();
        }
    }
    private GameObject GetClosestTrash()
    {
        GameObject[] trashClose;
        trashClose = GameObject.FindGameObjectsWithTag("trash");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject TrashType in trashClose)
        {
            Vector3 diff = TrashType.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = TrashType;
                distance = curDistance;
            }
        }
        return closest;
    }

    //If you want to make the trash getting removed if player is colliding with it remove the // below and then remove the lines in void Update()
    //that are the same as in void OnTriggerStay(Collider other)

    //private void OnTriggerStay(Collider other)
    //{
    //    var closestTrash = GetClosestTrash();
    //    if (closestTrash == null) return;
    //    if (InputScript.TrashRemoveActionInput)
    //    {
    //        var interactable = closestTrash.GetComponent<IInteractable>();
    //        if (interactable == null) return;
    //        interactable.Interact();
    //    }
    //}
}
