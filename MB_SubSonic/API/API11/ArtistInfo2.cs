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
public partial class ArtistInfo2 : ArtistInfoBase
{
    
        public List<ArtistID3> SimilarArtist { get; set; }
    
    public ArtistInfo2()
    {
        SimilarArtist = new List<ArtistID3>();
    }
}
}
#pragma warning restore
