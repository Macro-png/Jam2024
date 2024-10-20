using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscenaLabanderia : MonoBehaviour
{
    public GameObject uniforme;

    [SerializeField] public TextAsset mensajeDeSalidaJSON;
    [SerializeField] public TextAsset mensajeDeSalidaFinalJSON;

    // Start is called before the first frame update
    void Start()
    {
        DialogueManager.iteraciones = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(DialogueManager.iteraciones <= 0 && !DialogueManager.GetInstance().dialogueIsPlaying){
            if(EditJson.GetDatos().uniforme != 0 && EditJson.GetDatos().riot != 0 && EditJson.GetDatos().llaves != 0){
            DialogueManager.GetInstance().EnterDialogueMode(mensajeDeSalidaFinalJSON);
            }else{
                DialogueManager.GetInstance().EnterDialogueMode(mensajeDeSalidaJSON);
            }
        }

        
    }
}
