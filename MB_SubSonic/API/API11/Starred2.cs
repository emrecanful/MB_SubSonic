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
public partial class Starred2
{
    
        public List<ArtistID3> Artist { get; set; }
        public List<AlbumID3> Album { get; set; }
        public List<Child> Song { get; set; }
    
    public Starred2()
    {
        Song = new List<Child>();
        Album = new List<AlbumID3>();
        Artist = new List<ArtistID3>();
    }
}
}
#pragma warning restore
