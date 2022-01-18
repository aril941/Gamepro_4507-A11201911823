using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image on;
    [SerializeField] Image off;
    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted")){
            PlayerPrefs.SetInt("muted",0);
            Load();
        }
        else{
            Load();
        }
        ubahTombol();
        AudioListener.pause = muted;
    }

    public void OnButtonPress(){
        if(muted==false){
            muted=true;
            AudioListener.pause = true; 
        }
        else{
            muted = false;
            AudioListener.pause = false;
        }
        Save();
        ubahTombol();
    }

    private void Load(){
        muted = PlayerPrefs.GetInt("muted") ==1;
    }

    private void Save(){
        PlayerPrefs.SetInt("muted", muted ? 1:0);
    }

    private void ubahTombol(){
        if(muted==false){
            on.enabled = true;
            off.enabled = false;
        }
        else{
            on.enabled = false;
            off.enabled = true;
        }
    }


}
