using UnityEngine;
using System;

public class inventario : MonoBehaviour
{
    public int cantidadpociones =13 ; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            Reducionpociones();
    }
    public void Reducionpociones() {
        try
        {
            if(cantidadpociones == 0)
                throw new Exception("ya no hay mas pociones");
            cantidadpociones = (cantidadpociones - 1 <= 0) ? 0 : cantidadpociones - 1; 
            DEbugInventario();
        }
        catch (Exception inventario)
        {
            Debug.LogError("un error de inventario pasaodo " + inventario.Message);
        }
        finally {
            Debug.LogError("Se teermino todas las excepciones ");
        }
    }
    public void DEbugInventario() {
        Debug.Log("Se desconto la cantidad de pociones , pociones actuales " + cantidadpociones);
    }
}
/*El jugador tiene un inventario limitado y puede intentar usar objetos (por ejemplo, pociones). Si intenta usar un objeto que no tiene, se lanza una excepción.
Objetivo: Usar try-catch para manejar el intento de usar un objeto no existente en el inventario.
Requerimientos:
Crea una clase Inventario que contenga la cantidad de pociones que tiene el jugador
Al presionar la tecla Z la cantidad se reducira en 1
Usar try-catch para manejar el intento de usar un objeto no existente en el inventario.
*/