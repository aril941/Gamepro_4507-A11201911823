using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public Gradient gradient;
    [SerializeField] Slider setVolume;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume")){
            PlayerPrefs.SetFloat("musicVolume",1);
            Load();
        }
        else{
            Load();
        }
    }

    public void ChangeVolume(){
        AudioListener.volume = setVolume.value;
        Save();
    }

    public void Load(){
        setVolume.value = PlayerPrefs.GetFloat("musicVolume");
    }

    public void Save(){
        PlayerPrefs.SetFloat("musicVolume",setVolume.value);
    }
}
