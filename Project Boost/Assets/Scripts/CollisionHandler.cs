using System;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Hit Friendly");
                break;
            case "Finish":
                Debug.Log("Good Job! :)");
                break;
            case "Fuel":
                Debug.Log("You picked up fuel!");
                break;
            default:
                Debug.Log("You blew it!");
                break;
        }
    }
}
