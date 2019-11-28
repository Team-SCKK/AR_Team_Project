﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.UI
{
    /// <summary>
    /// Tooltip used for speech confirmation label. This inherits ToolTip class and provides generic text string interface for the label.
    /// To create your own speecn cofirmation label, override SpeechConfirmationTooltip and provide SetText(string s) and 
    /// TriggerConfirmationAnimation() functions. Assign the prefab to the SpeechInputHandler.cs
    /// </summary>
    public class SpeechConfirmationTooltip : ToolTip
    {
        public virtual void SetText(string labelText)
        {
            ToolTipText = labelText;
        }

        public virtual void TriggerConfirmedAnimation()
        {
            gameObject.GetComponent<Animator>().SetTrigger("Confirmed");
        }

    }
}
