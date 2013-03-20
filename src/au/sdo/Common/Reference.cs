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

namespace OpenADK.Library.au.Common{

/// <summary>References external content via a URL.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class Reference : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Reference
	/// </summary>
	public Reference() : base ( CommonDTD.REFERENCE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="mimeType">MIME type to indicate the content type to be expected when retrieving the external content.</param>
	///<param name="url">Location of external content.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;Reference&amp;gt; element</param>
	///
	public Reference( string mimeType, string url, string value ) : base( CommonDTD.REFERENCE )
	{
		this.MIMEType = mimeType;
		this.URL = url;
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Reference( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.REFERENCE_MIMETYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Reference&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;Reference&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.REFERENCE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.REFERENCE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>MIMEType</c> attribute.
	/// </summary>
	/// <value> The <c>MIMEType</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "MIME type to indicate the content type to be expected when retrieving the external content."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string MIMEType
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.REFERENCE_MIMETYPE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.REFERENCE_MIMETYPE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Description</c> attribute.
	/// </summary>
	/// <value> The <c>Description</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Contains an optional description of the content or a processing hint with regard to its structure (e.g. named standard, file layout or XSD). Contents may be mandated in instances of this type, or types that follow the AbstractContentPackageType pattern."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.REFERENCE_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.REFERENCE_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;URL&gt;</c> element.
	/// </summary>
	/// <value> The <c>URL</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Location of external content."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string URL
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.REFERENCE_URL ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.REFERENCE_URL, new SifString( value ), value );
		}
	}

}}
