using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class neutron : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    // Start is called before the first frame update
    void Start()
    {
        actions.Add("neuforward", neuForward);
        actions.Add("neuup", neuUp);
        actions.Add("neudown", neuDown);
        actions.Add("neuback", neuBack);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }


    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void neuForward()
    {
        transform.Translate(1, 0, 0);
    }



    private void neuBack()
    {
        transform.Translate(-1, 0, 0);
    }

    private void neuUp()
    {
        transform.Translate(0, 1, 0);
    }

    private void neuDown()
    {
        transform.Translate(0, -1, 0);
    }




}
