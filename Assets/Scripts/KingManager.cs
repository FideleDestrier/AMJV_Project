using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingManager : MonoBehaviour
{
    public GameObject king;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject getKing()
    {
        return king;
    }

    public void setKing(GameObject king)
    {
        this.king = king;
        king.transform.GetChild(1).gameObject.SetActive(true);
    }
}
