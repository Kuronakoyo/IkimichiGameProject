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
    //�LSE
    public void Secat()
    {
        a.PlayOneShot(_cat);
    }
    //����SE
    public void SeFootsteps()
    {
        a.PlayOneShot(_footsteps);
    }
    //��������ԂԂ�SE
    public void SeOjisan()
    {
        a.PlayOneShot(_ojisan);
    }
    //��������΂���
    public void SeOjisanwara()
    {
        a.PlayOneShot(_ojisanwara);
    }
    //����^�b�v�œ���Đ���SE
    public void Semovie()
    {
        a.PlayOneShot(_semovie);
    }
    //�`���b�g�R�����g�o��SE
    public void Sechat()
    {
        a.PlayOneShot(_chat);
    }
    //��o��SE
    public void Sehand()
    {
        a.PlayOneShot(_hand);
    }
}
