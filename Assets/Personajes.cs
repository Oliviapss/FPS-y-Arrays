using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personajes : MonoBehaviour
{
    public int nivelHambre;
    public Alimentos alimento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TomarAlimento(int valoralimentario)
    {
        nivelHambre -= valoralimentario;
        if (nivelHambre <= 0)
        {
            nivelHambre = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        Alimentos alimento;
        alimento = other.GetComponent<Alimentos>();
        TomarAlimento(alimento.valoralimentario);
    }
}

