using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ScoreController;

public class BoardHit : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Beanbag")
        {
            ScoreController.Instance.HitBoard();
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Beanbag")
        {
            ScoreController.Instance.UnhitBoard();
        }
    }
}
