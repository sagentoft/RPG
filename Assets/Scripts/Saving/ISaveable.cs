using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.SaveSystem
{
    public interface ISaveable
    {
        object CaptureState();
        void RestoreState(object state);
    }
}
