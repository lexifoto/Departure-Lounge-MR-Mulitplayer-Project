using UnityEngine;

public class EatTrigger : MonoBehaviour
{
    public AudioClip soundEffect;  // 拖入音效
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = soundEffect;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))  // 让所有被抓取的物体加 "Food" 标签
        {
            Debug.Log($"{other.gameObject.name} 碰到了头部！");

            // 播放音效
            if (soundEffect != null)
            {
                audioSource.Play();
            }

            // 销毁物体
            Destroy(other.gameObject);
        }
    }
}
