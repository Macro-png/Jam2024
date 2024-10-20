using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patioSceneManager : MonoBehaviour
{
    [SerializeField] public TextAsset mensajeDeSalidaJSON;

    // Start is called before the first frame update
    void Start(){
        DialogueManager.iteraciones = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(DialogueManager.iteraciones <= 0 && !DialogueManager.GetInstance().dialogueIsPlaying){
            DialogueManager.GetInstance().EnterDialogueMode(mensajeDeSalidaJSON);
        }
    }
}
