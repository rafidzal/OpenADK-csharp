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

namespace OpenADK.Library.us.Common{

/// <summary>An IdentificationInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class IdentificationInfo : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an IdentificationInfo
	/// </summary>
	public IdentificationInfo() : base ( CommonDTD.IDENTIFICATIONINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="code">Code indicating which identification system is used.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;IdentificationInfo&amp;gt; element</param>
	///
	public IdentificationInfo( IdentificationSystem code, string value ) : base( CommonDTD.IDENTIFICATIONINFO )
	{
		this.SetCode( code );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected IdentificationInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.IDENTIFICATIONINFO_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;IdentificationInfo&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;IdentificationInfo&amp;gt; element"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.IDENTIFICATIONINFO ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.IDENTIFICATIONINFO, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Code</c> attribute.
	/// </summary>
	/// <value> The <c>Code</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Code indicating which identification system is used."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( CommonDTD.IDENTIFICATIONINFO_CODE );
		}
		set
		{
			SetField( CommonDTD.IDENTIFICATIONINFO_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Code</c> attribute.
	/// </summary>
	/// <param name="val">A IdentificationSystem object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Code indicating which identification system is used."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetCode( IdentificationSystem val )
	{
		SetField( CommonDTD.IDENTIFICATIONINFO_CODE, val );
	}

}}