using UnityEngine;
using System.Collections;
using System.IO;                    // For parsing text file, StringReader
using System.Collections.Generic;    // For List
using UnityEngine.UI;
using System.Linq;
public class FileIO : MonoBehaviour
{

    public Transform contentWindow;

    public GameObject recallTextObject;

   

    public TextAsset wordfile;         // Text file (assigned from Editor)

    public List<string> lineList = new List<string>();        // List to hold all the lines read from the text file

    public string abc { get; private set; }

    void Start()
    {
        returnedLines = new List<int>();
        ReadWordList();
        recallTextObject.GetComponent<Text>().text = GetRandomLine();
        Instantiate(recallTextObject, contentWindow);
    }

    public void ReadWordList()
    {
        // Check if file exists before reading
        if (wordfile)
        {
            string line;
            StringReader textStream = new StringReader(wordfile.text);

            while ((line = textStream.ReadLine()) != null)
            {
                // Read each line from text file and add into list
                lineList.Add(line);
            }

            textStream.Close();
        }
    }

 
        // Returns random line from list
        private List<int> returnedLines;
private bool alreadyReturned = true;

    
    public string GetRandomLine()
    {
        int lineToReturn = Random.Range(0, lineList.Count);

        while (alreadyReturned)
        {
            if (returnedLines.Contains(lineToReturn))
                lineToReturn = Random.Range(0, lineList.Count);
            else
                alreadyReturned = false;
        }
        string abc = lineList[lineToReturn];
        return abc;
    }
    
    
}