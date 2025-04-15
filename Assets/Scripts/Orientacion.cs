using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientacion : MonoBehaviour
{
    public string nombreAlumno;
    public int año;
    public char espcialidad;

    HashSet<char> codigosEspecialidades = new HashSet<char> { 'T', 'D', 'G', 'H', 'M' };
    // Start is called before the first frame update
    void Start()
    {

        if(nombreAlumno == "")
        {
            Debug.Log("Error: El nombre del usuario no ha sido ingresado.");
            return;
        }
        if(año < 1 || año > 5)
        {
            Debug.Log("Error: El año no es valido.");
            return;
        }
        if (año < 3)
        {
            Debug.Log("Error: No estas en secundaria.");
            return;
        }
        if (!codigosEspecialidades.Contains(espcialidad))
        {
            Debug.Log("Error: La especialidad no es valida.");
            return;
        }

        Debug.Log("Exito: Muchas Gracias " + nombreAlumno + "!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
