using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.ShaderData;

public class Botones : MonoBehaviour
{
    [SerializeField] GameObject Play;
    [SerializeField] GameObject Camara;
    [SerializeField] GameObject Fondo;
    [SerializeField] GameObject Ajustes;
    [SerializeField] GameObject Salir;
    [SerializeField] GameObject Alto;
    [SerializeField] GameObject Bajo;
    [SerializeField] GameObject Medio;
    [SerializeField] GameObject Volver;
    [SerializeField] GameObject Sonido;
    [SerializeField] GameObject Musica;
    [SerializeField] GameObject MenúPlantas;
    [SerializeField] GameObject MenuPrincipal;
    float t;
    bool salir;
    private void Start()
    {
        t = 0;
        MenúPlantas.SetActive(false);
    }
    public void Salirjuego()
    {
        LeanTween.scale(Play, new Vector3(0, 0, 0), 1f).setDelay(.5f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Ajustes, new Vector3(0, 0, 0), 1f).setDelay(.5f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Salir, new Vector3(0, 0, 0), 1f).setDelay(.5f).setEase(LeanTweenType.easeInBack);


        salir = true;
    }
    public void AltoVol()
    {
        LeanTween.scale(Alto, new Vector3(0.85f, 0.85f, 0.85f), 1f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Medio, new Vector3(1, 1, 1), 1f).setEase(LeanTweenType.easeOutBack);
        LeanTween.scale(Bajo, new Vector3(1, 1, 1), 1f).setEase(LeanTweenType.easeOutBack);
        Musica.GetComponent<AudioSource>().volume = 0.75f;
    }
    public void MedioVol()
    {
        Musica.GetComponent<AudioSource>().volume = 0.5f;
        LeanTween.scale(Medio, new Vector3(0.85f, 0.85f, 0.85f), 1f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Alto, new Vector3(1, 1, 1), 1f).setEase(LeanTweenType.easeOutBack);
        LeanTween.scale(Bajo, new Vector3(1, 1, 1), 1f).setEase(LeanTweenType.easeOutBack);
    }
    public void BajoVol()
    {
        Musica.GetComponent<AudioSource>().volume = 0.25f;
        LeanTween.scale(Bajo, new Vector3(0.85f, 0.85f, 0.85f), 1f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Alto, new Vector3(1, 1, 1), 1f).setEase(LeanTweenType.easeOutBack);
        LeanTween.scale(Medio, new Vector3(1, 1, 1), 1f).setEase(LeanTweenType.easeOutBack);
    }
    public void menuSonido()
    {


        LeanTween.scale(Play, new Vector3(0, 0, 0), 1f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Ajustes, new Vector3(0, 0, 0), 1f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Salir, new Vector3(0, 0, 0), 1f).setEase(LeanTweenType.easeInBack);

        LeanTween.scale(Sonido, new Vector3(1, 1, 1), 1f).setDelay(1.0f).setEase(LeanTweenType.easeOutBack);
        LeanTween.scale(Alto, new Vector3(1, 1, 1), 1f).setDelay(1f).setEase(LeanTweenType.easeOutBack);
        LeanTween.scale(Medio, new Vector3(1, 1, 1), 1f).setDelay(1f).setEase(LeanTweenType.easeOutBack);
        LeanTween.scale(Bajo, new Vector3(1, 1, 1), 1f).setDelay(1f).setEase(LeanTweenType.easeOutBack);
        LeanTween.scale(Volver, new Vector3(1, 1, 1), 1f).setDelay(1f).setEase(LeanTweenType.easeOutBack);


    }

    public void VolverMenu()
    {
        LeanTween.scale(Alto, new Vector3(0, 0, 0), 1f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Medio, new Vector3(0, 0, 0), 1f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Bajo, new Vector3(0, 0, 0), 1f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Sonido, new Vector3(0, 0, 0), 1f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Volver, new Vector3(0, 0, 0), 1f).setEase(LeanTweenType.easeInBack);

        LeanTween.scale(Play, new Vector3(1, 1, 1), 1f).setDelay(1f).setEase(LeanTweenType.easeOutBack);
        LeanTween.scale(Ajustes, new Vector3(1, 1, 1), 1f).setDelay(1f).setEase(LeanTweenType.easeOutBack);
        LeanTween.scale(Salir, new Vector3(1, 1, 1), 1f).setDelay(1f).setEase(LeanTweenType.easeOutBack);


    }
    public void jugar()
    {
        LeanTween.scale(this.gameObject, new Vector3(0, 0, 0), 1f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Ajustes, new Vector3(0, 0, 0), 1f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Salir, new Vector3(0, 0, 0), 1f).setEase(LeanTweenType.easeInBack);
        LeanTween.scale(Fondo, new Vector3(0, 0, 0), 1f).setDelay(1f).setEase(LeanTweenType.easeInSine);
        MenúPlantas.SetActive(true);
       

    }



    private void Update()
    {
        if (salir)
        {
            t = t + 1;
            if (t % 500 == 0)
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
        if (MenúPlantas.GetComponent<options>().aparecermenu == true)
        {

            LeanTween.scale(Play, new Vector3(1, 1, 1), 1f).setDelay(1f).setEase(LeanTweenType.easeOutBack);
            LeanTween.scale(Ajustes, new Vector3(1, 1, 1), 1f).setDelay(1f).setEase(LeanTweenType.easeOutBack);
            LeanTween.scale(Salir, new Vector3(1, 1, 1), 1f).setDelay(1f).setEase(LeanTweenType.easeOutBack);
            LeanTween.scale(Fondo, new Vector3(1, 1, 1), 1f).setDelay(1f).setEase(LeanTweenType.easeOutSine);
            MenúPlantas.SetActive(false);
            MenúPlantas.GetComponent<options>().aparecermenu = false;
        }
    }
}



