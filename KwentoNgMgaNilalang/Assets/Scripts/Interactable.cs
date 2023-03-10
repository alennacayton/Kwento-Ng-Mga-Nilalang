using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool isInRange;
    [SerializeField] private float triggerRadius = 1f; 
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
        if(isInRange && Input.GetKeyDown(interactKey))
        {
            Debug.Log("Item has been interacted with!!!");
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        //Debug.Log("Item is In Range");
        isInRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("Item is Out of Range");
        isInRange = false;
    }


}
