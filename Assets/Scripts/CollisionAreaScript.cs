using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionAreaScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtCollisionInfo;
    [SerializeField] GameObject panel;
    public bool tengoBoleadoras = false;
    public bool tengoGuitarra = false;
    public bool tengoCaballo = false;
    public bool tengoMate = false;
    public bool tengoBotella = false;
    public bool tengoPistola = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        panel.SetActive(true);
        
        txtCollisionInfo.text = collision.gameObject.name;
        
        if (collision.gameObject.name == "Boleadora")
        {
            mostrarUI(collision.gameObject.name);
            if(Input.GetKeyDown(KeyCode.E))
            Destroy(collision.gameObject);
            tengoBoleadoras = true;
        }
        if (collision.gameObject.name == "Guitarra")
        {
            mostrarUI(collision.gameObject.name);
            Destroy(collision.gameObject);
            tengoGuitarra = true;
        }
        if (collision.gameObject.name == "Caballo")
        {
            mostrarUI(collision.gameObject.name);
            Destroy(collision.gameObject);
            tengoCaballo = true;
        }
        if (collision.gameObject.name == "Botella")
        {
            mostrarUI(collision.gameObject.name);
            Destroy(collision.gameObject);
            tengoBotella = true;
        }
        if (collision.gameObject.name == "Mate")
        {
            mostrarUI(collision.gameObject.name);
            Destroy(collision.gameObject);
            tengoMate = true;
        }
        if (collision.gameObject.name == "Pistola")
        {
            mostrarUI(collision.gameObject.name);
            Destroy(collision.gameObject);
            tengoPistola = true;
        }
        //Debug.Log(collision.gameObject.name);
    }
    private void OnCollisionExit(Collision collision)
    {
        panel.SetActive(false);
        txtCollisionInfo.text = "";
    }
    void mostrarUI(string collision)
    {
        txtCollisionInfo.text = "Presione E para agarrar " + collision;
    }
}
