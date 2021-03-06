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

namespace OpenADK.Library.us.Assessment{

/// <summary>A StudentSpecialEvent</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class StudentSpecialEvent : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a StudentSpecialEvent
	/// </summary>
	public StudentSpecialEvent() : base ( AssessmentDTD.STUDENTSPECIALEVENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="code">A code indicating the type of special event. Code values are determined by the assessment program..</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;StudentSpecialEvent&amp;gt; element</param>
	///
	public StudentSpecialEvent( string code, string value ) : base( AssessmentDTD.STUDENTSPECIALEVENT )
	{
		this.Code = code;
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentSpecialEvent( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.STUDENTSPECIALEVENT_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentSpecialEvent&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;StudentSpecialEvent&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.STUDENTSPECIALEVENT ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.STUDENTSPECIALEVENT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Code</c> attribute.
	/// </summary>
	/// <value> The <c>Code</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "A code indicating the type of special event. Code values are determined by the assessment program.."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Code
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.STUDENTSPECIALEVENT_CODE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.STUDENTSPECIALEVENT_CODE, new SifString( value ), value );
		}
	}

}}
