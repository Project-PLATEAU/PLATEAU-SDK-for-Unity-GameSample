using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultView : ViewBase
{
    [SerializeField] private ExtendButton toTitleButton;

    void Start()
    {

    }
    public override IEnumerator Wait()
    {
        while (true)
        {
            //タイトルに戻る
            if (toTitleButton.IsClicked)
            {
                yield break;
            }

            yield return null;
        }
    }
}