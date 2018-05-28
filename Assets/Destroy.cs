using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
    private Renderer renderer;
    private GameObject maincamera;
    void Start()
    {
        maincamera = GameObject.Find("Main Camera");
       
    }
    void Update()
    {
        if (transform.position.z < maincamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
   /* void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }*/
}