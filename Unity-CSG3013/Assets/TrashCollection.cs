using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCollection : MonoBehaviour
{

    public int bagsCollected;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trashbag"))
        {
            Destroy(other.gameObject);
            bagsCollected++;
        }
    }
}
