using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] public AudioSource a;
    [SerializeField] public AudioClip _cat;
    [SerializeField] public AudioClip _footsteps;
    [SerializeField] public AudioClip _ojisan;
    [SerializeField] public AudioClip _ojisanwara;
    [SerializeField] public AudioClip _semovie;
    [SerializeField] public AudioClip _chat;
    [SerializeField] public AudioClip _hand;
    //猫SE
    public void Secat()
    {
        a.PlayOneShot(_cat);
    }
    //足音SE
    public void SeFootsteps()
    {
        a.PlayOneShot(_footsteps);
    }
    //おじさんぶつぶつSE
    public void SeOjisan()
    {
        a.PlayOneShot(_ojisan);
    }
    //おじさん笑い声
    public void SeOjisanwara()
    {
        a.PlayOneShot(_ojisanwara);
    }
    //動画タップで動画再生時SE
    public void Semovie()
    {
        a.PlayOneShot(_semovie);
    }
    //チャットコメント出現SE
    public void Sechat()
    {
        a.PlayOneShot(_chat);
    }
    //手出現SE
    public void Sehand()
    {
        a.PlayOneShot(_hand);
    }
}
