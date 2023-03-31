using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLeft : MonoBehaviour
{

    public void OnTurn()
    {
        GameObject.Find("Lily habillée v3(Clone)").transform.rotation = Quaternion.Euler(0,-90+GameObject.Find("Lily habillée v3(Clone)").transform.eulerAngles.y,0);
    }
}
