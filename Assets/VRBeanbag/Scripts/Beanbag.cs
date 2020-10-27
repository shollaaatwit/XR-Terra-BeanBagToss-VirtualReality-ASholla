using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BagsController;


public class Beanbag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Thrown()
    {
        BagsController.Instance.BagOnDeck();
        gameObject.layer = 0;

    }
}
