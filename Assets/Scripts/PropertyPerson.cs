using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyPerson
{
    public string FirstName {get;set;}
    public string lastName {get;set;}
    public string FullName 
    {
        get
        { 
            return $"{this.FirstName} {this.lastName}";
        }
    }

}
