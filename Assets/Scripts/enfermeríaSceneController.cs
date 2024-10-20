using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enfermeríaSceneController : MonoBehaviour
{

    public GameObject bolso;
    public GameObject enferemera;

    [SerializeField] public TextAsset mensajeDeSalidaJSON;
    [SerializeField] public TextAsset enferemeraPuedeIrse;
    [SerializeField] public TextAsset TomarDeBolso;

    // Update is called once per frame
    void Start(){
        DialogueManager.iteraciones = 2;
            
            
    }
    

    void Update(){
        if(EditJson.GetDatos().fish_lavanderia != 0)
                enferemera.GetComponent<DialogueTrigger>().inkJSON = enferemeraPuedeIrse;
        if(DialogueManager.iteraciones <= 0 && !DialogueManager.GetInstance().dialogueIsPlaying){
            Datos change = EditJson.GetDatos();
            change.nurseHappy_enfermeria = 0;
            EditJson.SetDatos(change);
            DialogueManager.GetInstance().EnterDialogueMode(mensajeDeSalidaJSON);
        }
        if(EditJson.GetDatos().nurseHappy_enfermeria != 0){
            Datos change = EditJson.GetDatos();
            change.nurseHappy_enfermeria = 1;
            EditJson.SetDatos(change);
            bolso.GetComponent<DialogueTrigger>().inkJSON = TomarDeBolso;
            enferemera.SetActive(false);
        }
    }

}
