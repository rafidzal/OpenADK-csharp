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

/// <summary>An IncidentCategory</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class IncidentCategory : SifElement
{
	/// <summary>
	/// Creates an instance of an IncidentCategory
	/// </summary>
	public IncidentCategory() : base ( StudentDTD.INCIDENTCATEGORY ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected IncidentCategory( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies the type of incident being reported."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( StudentDTD.INCIDENTCATEGORY_CODE );
		}
		set
		{
			SetField( StudentDTD.INCIDENTCATEGORY_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A IncidentCodeType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies the type of incident being reported."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetCode( IncidentCodeType val )
	{
		SetField( StudentDTD.INCIDENTCATEGORY_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "List of other codes or strings that crosswalk to or serve as translations of the Code element.  If Code changes and OtherCode elements are supported, both Code and all associated OtherCode elements must be present."</para>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( StudentDTD.INCIDENTCATEGORY_OTHERCODELIST);
		}
		set
		{
			RemoveChild( StudentDTD.INCIDENTCATEGORY_OTHERCODELIST);
			if( value != null)
			{
				AddChild( StudentDTD.INCIDENTCATEGORY_OTHERCODELIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CodeComment&gt;</c> element.
	/// </summary>
	/// <value> The <c>CodeComment</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A short comment clarifying the discipline code (e.g. for Nonsexual Harassment could detail "Racial comment, pushing, name-calling" or "Cell phone violation. Second offense.")"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string CodeComment
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.INCIDENTCATEGORY_CODECOMMENT ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.INCIDENTCATEGORY_CODECOMMENT, new SifString( value ), value );
		}
	}

}}
