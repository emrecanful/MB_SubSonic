// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.31
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace MusicBeePlugin.API11
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;

[DebuggerStepThrough]
public partial class SearchResult
{
    
        public List<Child> Match { get; set; }
        public int Offset { get; set; }
        public int TotalHits { get; set; }
    
    public SearchResult()
    {
        Match = new List<Child>();
    }
}
}
#pragma warning restore
