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
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Instr{

/// <summary>Description of location of resource, i.e. location in library or URL, community resource, outside resource supplier.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class ResourceLocation : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ResourceLocation
	/// </summary>
	public ResourceLocation() : base ( InstrDTD.RESOURCELOCATION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="referenceType">A qualifying attribute for the ResourceLocation payload. If ReferenceType is "URI", the payload contains a web address where the resource can be found.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;ResourceLocation&amp;gt; element</param>
	///
	public ResourceLocation( ReferenceType referenceType, string value ) : base( InstrDTD.RESOURCELOCATION )
	{
		this.SetReferenceType( referenceType );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ResourceLocation( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InstrDTD.RESOURCELOCATION_REFERENCETYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ResourceLocation&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;ResourceLocation&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.RESOURCELOCATION ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.RESOURCELOCATION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>ReferenceType</c> attribute.
	/// </summary>
	/// <value> The <c>ReferenceType</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "A qualifying attribute for the ResourceLocation payload. If ReferenceType is "URI", the payload contains a web address where the resource can be found."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string ReferenceType
	{
		get
		{ 
			return GetFieldValue( InstrDTD.RESOURCELOCATION_REFERENCETYPE );
		}
		set
		{
			SetField( InstrDTD.RESOURCELOCATION_REFERENCETYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>ReferenceType</c> attribute.
	/// </summary>
	/// <param name="val">A ReferenceType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "A qualifying attribute for the ResourceLocation payload. If ReferenceType is "URI", the payload contains a web address where the resource can be found."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetReferenceType( ReferenceType val )
	{
		SetField( InstrDTD.RESOURCELOCATION_REFERENCETYPE, val );
	}

}}
