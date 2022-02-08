using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //SoundManager.Instance.Play_SE(もしくはBGM)(x,y); で呼び出せるよ!!
    public static SoundManager Instance { get => _instance; }
    static SoundManager _instance;
    [SerializeField]
    List<AudioClip> seList = new List<AudioClip>();
    [SerializeField]
    List<AudioClip> bgmList = new List<AudioClip>();
    // AddComponent した AudioSource のリスト
    [SerializeField]
    List<AudioSource> soundSource = new List<AudioSource>();
    private void Awake()
    {
        _instance = this;
    }
    // SE関連
    public void Play_SE(int source_num, int se_num)
    {
        soundSource[source_num].PlayOneShot(seList[se_num]);
    }
    // bgm関連
    public void Play_BGM(int source_num, int bgm_num)
    {
        soundSource[source_num].PlayOneShot(bgmList[bgm_num]);
    }
    public void Stop_SE(int source_num, int se_num)
    {
        soundSource[source_num].Stop();
    }
}
