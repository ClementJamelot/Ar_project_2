using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchGame : MonoBehaviour
{
    [SerializeField]private GameObject Lily;

    public void onLaunch()
    {
        Instantiate(Lily,new Vector3(0,0,0),new Quaternion(0,0,0,0));
    }
}
