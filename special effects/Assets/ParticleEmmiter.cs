using UnityEngine;
public class ParticleEmmiter : MonoBehaviour
{   public float timer = 0;
    void Start()
    {   GetComponent<ParticleSystem>().Stop();  }
    void Update()
    {   timer -= Time.deltaTime;
        if (timer < 0)       
            GetComponent<ParticleSystem>().Stop();
        if (Input.GetKey(KeyCode.Space) && timer <= 0)
        {   GetComponent<ParticleSystem>().Play();
            timer = 3; }
        print(timer);
    }
}
