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

/// <summary>A StudentActivityInfoLocation</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class StudentActivityInfoLocation : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a StudentActivityInfoLocation
	/// </summary>
	public StudentActivityInfoLocation() : base ( StudentDTD.STUDENTACTIVITYINFOLOCATION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">Values: Classroom, School, District, Campus, IntermediateUnit, StateEducationAgency</param>
	///
	public StudentActivityInfoLocation( string type ) : base( StudentDTD.STUDENTACTIVITYINFOLOCATION )
	{
		this.Type = type;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentActivityInfoLocation( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.STUDENTACTIVITYINFOLOCATION_TYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Values: Classroom, School, District, Campus, IntermediateUnit, StateEducationAgency"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Type
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTACTIVITYINFOLOCATION_TYPE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTACTIVITYINFOLOCATION_TYPE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocationName&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocationName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name of the location"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string LocationName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTACTIVITYINFOLOCATION_LOCATIONNAME ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTACTIVITYINFOLOCATION_LOCATIONNAME, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;LocationRefId&gt;</c> element.</summary>
	/// <param name="SifRefObject">Type of SIF object Location points to.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;StudentActivityInfoLocationRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setLocationRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>LocationRefId</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetLocationRefId( string SifRefObject, string Value ) {
		RemoveChild( StudentDTD.STUDENTACTIVITYINFOLOCATION_LOCATIONREFID);
		AddChild( StudentDTD.STUDENTACTIVITYINFOLOCATION_LOCATIONREFID, new StudentActivityInfoLocationRefId( SifRefObject, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocationRefId&gt;</c> element.
	/// </summary>
	/// <value> A StudentActivityInfoLocationRefId </value>
	/// <remarks>
	/// <para>To remove the <c>StudentActivityInfoLocationRefId</c>, set <c>LocationRefId</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public StudentActivityInfoLocationRefId LocationRefId
	{
		get
		{
			return (StudentActivityInfoLocationRefId)GetChild( StudentDTD.STUDENTACTIVITYINFOLOCATION_LOCATIONREFID);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTACTIVITYINFOLOCATION_LOCATIONREFID);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTACTIVITYINFOLOCATION_LOCATIONREFID, value );
			}
		}
	}

}}
