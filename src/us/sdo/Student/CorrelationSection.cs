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

namespace OpenADK.Library.us.Student{

/// <summary>A CorrelationSection</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class CorrelationSection : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a CorrelationSection
	/// </summary>
	public CorrelationSection() : base ( StudentDTD.CORRELATIONSECTION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="primary">Indicate whether a SectionInfo is primary. Only one SectionInfo in the CorrelationSectionList can be primary.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;CorrelationSection&amp;gt; element</param>
	///
	public CorrelationSection( Primary primary, string value ) : base( StudentDTD.CORRELATIONSECTION )
	{
		this.SetPrimary( primary );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected CorrelationSection( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.CORRELATIONSECTION_PRIMARY }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CorrelationSection&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;CorrelationSection&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.CORRELATIONSECTION ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.CORRELATIONSECTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Primary</c> attribute.
	/// </summary>
	/// <value> The <c>Primary</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Indicate whether a SectionInfo is primary. Only one SectionInfo in the CorrelationSectionList can be primary."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Primary
	{
		get
		{ 
			return GetFieldValue( StudentDTD.CORRELATIONSECTION_PRIMARY );
		}
		set
		{
			SetField( StudentDTD.CORRELATIONSECTION_PRIMARY, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Primary</c> attribute.
	/// </summary>
	/// <param name="val">A Primary object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Indicate whether a SectionInfo is primary. Only one SectionInfo in the CorrelationSectionList can be primary."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetPrimary( Primary val )
	{
		SetField( StudentDTD.CORRELATIONSECTION_PRIMARY, val );
	}

}}
