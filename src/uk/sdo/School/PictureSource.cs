// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.School{

/// <summary>A PictureSource</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class PictureSource : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a PictureSource
	/// </summary>
	public PictureSource() : base ( SchoolDTD.PICTURESOURCE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">The way the picture is specified.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;PictureSource&amp;gt; element</param>
	///
	public PictureSource( PictureType type, string value ) : base( SchoolDTD.PICTURESOURCE )
	{
		this.SetType( type );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PictureSource( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { SchoolDTD.PICTURESOURCE_TYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PictureSource&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;PictureSource&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.PICTURESOURCE ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.PICTURESOURCE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The way the picture is specified."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( SchoolDTD.PICTURESOURCE_TYPE );
		}
		set
		{
			SetField( SchoolDTD.PICTURESOURCE_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <param name="val">A PictureType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The way the picture is specified."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetType( PictureType val )
	{
		SetField( SchoolDTD.PICTURESOURCE_TYPE, val );
	}

}}
