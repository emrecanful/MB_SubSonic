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
public partial class Playlist
{
    
        public List<string> AllowedUser { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Owner { get; set; }
        public bool Public { get; set; }
        public int SongCount { get; set; }
        public int Duration { get; set; }
        public System.DateTime Created { get; set; }
        public string CoverArt { get; set; }
}
}
#pragma warning restore
