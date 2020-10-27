using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagsController : MonoBehaviour
{

    public static BagsController Instance;
    public GameObject beanbagPrefab;
    public Transform spawnTrans;



    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void Start()
    {
        BagOnDeck();
        
    }

    void Update()
    {
        
    }

    public void BagOnDeck()
    {
        Instantiate(beanbagPrefab, spawnTrans);

    }
}
