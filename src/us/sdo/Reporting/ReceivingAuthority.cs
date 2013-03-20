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
using OpenADK.Library.Infra;

namespace OpenADK.Library.us.Reporting{

/// <summary>The authority for whom the report is intended, usually the same authority that defines this manifest.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class ReceivingAuthority : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ReceivingAuthority
	/// </summary>
	public ReceivingAuthority() : base ( ReportingDTD.RECEIVINGAUTHORITY ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifRefObject">The name of the object referenced.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;ReceivingAuthority&amp;gt; element</param>
	///
	public ReceivingAuthority( string sifRefObject, string value ) : base( ReportingDTD.RECEIVINGAUTHORITY )
	{
		this.SIF_RefObject = sifRefObject;
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ReceivingAuthority( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { ReportingDTD.RECEIVINGAUTHORITY_SIF_REFOBJECT }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReceivingAuthority&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;ReceivingAuthority&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ReportingDTD.RECEIVINGAUTHORITY ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.RECEIVINGAUTHORITY, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SIF_RefObject</c> attribute.
	/// </summary>
	/// <value> The <c>SIF_RefObject</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The name of the object referenced."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string SIF_RefObject
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ReportingDTD.RECEIVINGAUTHORITY_SIF_REFOBJECT ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.RECEIVINGAUTHORITY_SIF_REFOBJECT, new SifString( value ), value );
		}
	}

}}
