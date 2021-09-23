using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class electro : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    // Start is called before the first frame update
    void Start()
    {
        actions.Add("eleforward", eleForward);
        actions.Add("eleup", eleUp);
        actions.Add("eledown", eleDown);
        actions.Add("eleback", eleBack);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }


    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void eleForward()
    {
        transform.Translate(1, 0, 0);
    }



    private void eleBack()
    {
        transform.Translate(-1, 0, 0);
    }

    private void eleUp()
    {
        transform.Translate(0, 1, 0);
    }

    private void eleDown()
    {
        transform.Translate(0, -1, 0);
    }




}
