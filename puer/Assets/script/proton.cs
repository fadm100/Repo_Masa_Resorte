using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class proton : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    // Start is called before the first frame update
    void Start()
    {
        actions.Add("proforward", proForward);
        actions.Add("proup", proUp);
        actions.Add("prodown", proDown);
        actions.Add("proback", proBack);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }


    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void proForward()
    {
        transform.Translate(1, 0, 0);
    }



    private void proBack()
    {
        transform.Translate(-1, 0, 0);
    }

    private void proUp()
    {
        transform.Translate(0, 1, 0);
    }

    private void proDown()
    {
        transform.Translate(0, -1, 0);
    }




}
