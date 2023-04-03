using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Collision : MonoBehaviour
{
    [SerializeField] private GameObject end;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if(other.tag=="Player")
        {
            int numb_score=int.Parse(GameObject.Find("Accompli").GetComponent<TextMeshProUGUI>().text) + 1;
            GameObject.Find("Accompli").GetComponent<TextMeshProUGUI>().text = numb_score.ToString();
            if(numb_score==4)
            {
                Destroy(GameObject.Find("PlayCanvas(Clone)").gameObject);
                Instantiate(end);
            }
            Destroy(this.gameObject);
        }
    }
}
