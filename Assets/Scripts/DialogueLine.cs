using UnityEngine;

[System.Serializable]
public class DialogueLine
{
    [TextArea(1, 1)]
    public string speaker;

    [TextArea(1, 1)]
    public string dialogue;

    [TextArea(1, 1)]
    public string hint;

    public Color dialogueColor;
    public bool advanceManually;
    public float advanceDelay;
}
