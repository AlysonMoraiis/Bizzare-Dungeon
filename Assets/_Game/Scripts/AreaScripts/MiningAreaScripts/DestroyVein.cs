using UnityEngine;

public class DestroyVein : MonoBehaviour
{
    [SerializeField]
    private int vida = 3;
    [SerializeField]
    private SoundManager soundManager;
    [SerializeField]
    private AudioClip destroyAudio;

    public void MiningTouch()
    {
        vida -= 1;
        if(vida == 0)
        {
            Destroy(gameObject);
            soundManager.PlaySound(destroyAudio);
        }
    }
}
