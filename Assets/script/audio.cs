using UnityEngine;
using System.Collections;

public class audio : MonoBehaviour
{
    AudioSource aud;
    public float sensitivity = 100.0f;
    public float loudness = 0.0f;
    // Use this for initialization
    public float frequency = 0.0f;
    public float change = 0.0f;
    public float tmp = 0.0f;
    void Start()
    {
        //transform.Translate(0, -10, 0);
        aud = GetComponent<AudioSource>();
        //aud.clip = Microphone.Start("", true, 10, 44100);
        aud.clip = Microphone.Start("", true, 10, 11025);
        aud.loop = true;
        aud.mute = false;
        while (!(Microphone.GetPosition(null) > 0)) { }
        aud.Play();
    }

    // Update is called once per frame
    void Update()
    {
        tmp = frequency;
        loudness = GetAveragedVolume() * sensitivity;
        frequency = GetFundamentalFrequency()-200;
        if (frequency < 800  && loudness > 0.1)
        {  }
        else { frequency = tmp;  }
        change = frequency - tmp;
        transform.Translate(0, change / 20, 0);
        Debug.Log("recording~~~~~~~~~~~~~~loudness" + loudness);
        Debug.Log("recording~~~~~~~~~~~~~~frequency" + frequency);
        Debug.Log("recording~~~~~~~~~~~~~~change" + change );
        //Debug.Log("aud = " + aud);
    }
    float GetAveragedVolume()
    {
        float[] data = new float[256];
        float a = 0;
        aud.GetOutputData(data, 0);
        foreach (float s in data)
        {
            a += Mathf.Abs(s);
        }
        return a / 256;
    }
    float GetFundamentalFrequency()
    {
        float fundamentalFrequency = 0.0f;
        float[] data = new float[8192];
        aud.GetSpectrumData(data, 0, FFTWindow.BlackmanHarris);
        float s = 0.0f;
        int i = 0;
        for (int j = 1; j < 8192; j++)
        {
            if (s < data[j])
            {
                s = data[j];
                i = j;
            }
        }
        fundamentalFrequency = i * 44100 / 8192;
        return fundamentalFrequency;
    }
}