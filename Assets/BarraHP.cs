using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraHP : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.GetComponent<Slider>();
    }

    public void CambiarHP(float hPmax)
    {
        slider.maxValue = hPmax;
    }
    public void CambiarHPactual(float cantidadactual)
    {
        slider.value = cantidadactual;
    }
public void IniciarBarra(float cantidadhp) 
    {
        CambiarHP(cantidadhp);
        CambiarHPactual(cantidadhp);
    }
}
