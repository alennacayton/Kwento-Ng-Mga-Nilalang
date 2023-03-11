using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool isInRange;
<<<<<<< Updated upstream
    [SerializeField] private float triggerRadius = 1f; 
=======
    [SerializeField] private float triggerRadius = 3f;
>>>>>>> Stashed changes
    [SerializeField] private KeyCode interactKey;

    // Start is called before the first frame update
    private void Start()
    {
        isInRange = false;
        interactKey = KeyCode.E;
        GetComponent<CircleCollider2D>().radius = triggerRadius;
    }

    private void Update()
    {
<<<<<<< Updated upstream
        if(isInRange && Input.GetKeyDown(interactKey))
=======
        if (isInRange && Input.GetKeyDown(interactKey))
>>>>>>> Stashed changes
        {
            Debug.Log("Item has been interacted with!!!");
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
<<<<<<< Updated upstream
    { 
        //Debug.Log("Item is In Range");
=======
    {
        Debug.Log("Item is In Range");
>>>>>>> Stashed changes
        isInRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
<<<<<<< Updated upstream
        //Debug.Log("Item is Out of Range");
=======
        Debug.Log("Item is Out of Range");
>>>>>>> Stashed changes
        isInRange = false;
    }


}
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
