using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class ButtonPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

[SerializeField]private GameObject lily;

[SerializeField]private bool buttonPressed;
[SerializeField]private float speed = 0.6f;

 
public void Start()
{
    //Initialisation du bouton et calcule de la distance que peut parcourir le canon
    buttonPressed = false;
    
    
    
}
//Detection de l'appuie sur le bouton
public void OnPointerDown(PointerEventData eventData)
{
    buttonPressed = true;
}
public void OnPointerUp(PointerEventData eventData)
{
    buttonPressed = false;
}
 
void Update()
{
    //Bouton presser alors mouvement activer, la direction est donnée par x qui est lié au bouton
    //Bouton non presser alors mouvment immobile 
    if(buttonPressed == true)
    {  
        lily.transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
}