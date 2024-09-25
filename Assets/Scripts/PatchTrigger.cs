using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatchTrigger : MonoBehaviour
{
    public Patch patch;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MoveMyPosition();
        }
    }

    void MoveMyPosition()
    {
        patch.pathManager.AssignNewPositon(patch.index);
    }
}
