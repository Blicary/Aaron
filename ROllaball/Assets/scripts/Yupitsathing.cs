using UnityEngine;
using System.Collections;

public class Yupitsathing : MonoBehaviour
{
    public Material mat_orig;
    public Material mat_troll;

    private bool current_mat_orig = true;
    private float face_blink_seconds = 0.5f;
    private float timer;

    public void Start()
    {
        timer = face_blink_seconds;
    }

    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = face_blink_seconds;
            ToggleMat();
        }

        FlashScreen();
    }

    private void ToggleMat()
    {
        if (current_mat_orig)
            renderer.material = mat_troll;
        else
            renderer.material = mat_orig;

        current_mat_orig = !current_mat_orig;
    }

    public void FlashScreen()
    {
        Camera.main.backgroundColor = new Color(Random.Range(0.3f, 0.6f), 0, 1);
    }
    
}
