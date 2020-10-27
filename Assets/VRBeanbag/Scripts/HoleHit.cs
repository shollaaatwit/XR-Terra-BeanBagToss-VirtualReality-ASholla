using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ScoreController;

public class HoleHit : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Beanbag")
        {
            ScoreController.Instance.HitHole();
        }

    }
}
