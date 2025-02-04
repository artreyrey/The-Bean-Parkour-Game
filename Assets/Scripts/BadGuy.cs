using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BadGuy
{
    private int _pointValue;

    public int PointValue {
        set
        {
            if (value > 0)
            {
                _pointValue = value;
            }
            else
            {
                _pointValue = 0;
            }
        }
        get
        {
            return _pointValue;
        }

    }
    public int Bonus {get; set;}
}
