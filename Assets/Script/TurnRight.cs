using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTurn()
    {
        
        this.transform.rotation = Quaternion.Euler(0,90+this.transform.eulerAngles.y,0);
    }
}
