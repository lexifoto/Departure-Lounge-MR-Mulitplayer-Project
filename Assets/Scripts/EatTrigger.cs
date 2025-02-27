using UnityEngine;

public class EatTrigger : MonoBehaviour
{
    public AudioClip soundEffect;  // ������Ч
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = soundEffect;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))  // �����б�ץȡ������� "Food" ��ǩ
        {
            Debug.Log($"{other.gameObject.name} ������ͷ����");

            // ������Ч
            if (soundEffect != null)
            {
                audioSource.Play();
            }

            // ��������
            Destroy(other.gameObject);
        }
    }
}
