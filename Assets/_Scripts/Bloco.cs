using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    public int vidas;
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (vidas <= 1){
            Destroy(gameObject);
        }

        vidas--;
    }
    // Start is called before the first frame update
    void Start()
    {
        vidas = Random.Range(1,3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
