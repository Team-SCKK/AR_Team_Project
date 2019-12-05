using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class VoiceCommand : MonoBehaviour
{

    public GameObject MenuPrefab;
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    // Start is called before the first frame update
    void Start()
    {
        //Create keywords for keyword recognizer
        keywords.Add("Open Menu", () =>
        {
            // action to be performed when this keyword is spoken
            Debug.Log("Open Menu");
            MenuPrefab.SetActive(true);

        });
        keywords.Add("Close Menu", () =>
        {
            // action to be performed when this keyword is spoken
            Debug.Log("Close Menu");
            MenuPrefab.SetActive(false);

        });
        

        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        // if the keyword recognized is in our dictionary, call that Action.
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
