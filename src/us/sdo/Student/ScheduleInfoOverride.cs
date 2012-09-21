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

/// <summary>A complete replacement of the ScheduleInfo of the section for this student; this should be a subset of the schedule information for the section</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class ScheduleInfoOverride : SifElement
{
	/// <summary>
	/// Creates an instance of a ScheduleInfoOverride
	/// </summary>
	public ScheduleInfoOverride() : base ( StudentDTD.SCHEDULEINFOOVERRIDE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="overrideValue">Designates whether or not scheduling information has been overridden with different values for this student.</param>
	///<param name="termInfoRefId">The ID (GUID) of the term to which this override information relates for this student.</param>
	///
	public ScheduleInfoOverride( YesNo overrideValue, string termInfoRefId ) : base( StudentDTD.SCHEDULEINFOOVERRIDE )
	{
		this.SetOverride( overrideValue );
		this.TermInfoRefId = termInfoRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ScheduleInfoOverride( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.SCHEDULEINFOOVERRIDE_OVERRIDE, StudentDTD.SCHEDULEINFOOVERRIDE_TERMINFOREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Override</c> attribute.
	/// </summary>
	/// <value> The <c>Override</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Designates whether or not scheduling information has been overridden with different values for this student."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Override
	{
		get
		{ 
			return GetFieldValue( StudentDTD.SCHEDULEINFOOVERRIDE_OVERRIDE );
		}
		set
		{
			SetField( StudentDTD.SCHEDULEINFOOVERRIDE_OVERRIDE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Override</c> attribute.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Designates whether or not scheduling information has been overridden with different values for this student."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetOverride( YesNo val )
	{
		SetField( StudentDTD.SCHEDULEINFOOVERRIDE_OVERRIDE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>TermInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>TermInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) of the term to which this override information relates for this student."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string TermInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHEDULEINFOOVERRIDE_TERMINFOREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHEDULEINFOOVERRIDE_TERMINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MeetingTimeList&gt;</c> element.
	/// </summary>
	/// <value> A MeetingTimeList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Time(s) this section meets for this student; this should be a subset of the meeting times for the section"</para>
	/// <para>To remove the <c>MeetingTimeList</c>, set <c>MeetingTimeList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public MeetingTimeList MeetingTimeList
	{
		get
		{
			return (MeetingTimeList)GetChild( StudentDTD.SCHEDULEINFOOVERRIDE_MEETINGTIMELIST);
		}
		set
		{
			RemoveChild( StudentDTD.SCHEDULEINFOOVERRIDE_MEETINGTIMELIST);
			if( value != null)
			{
				AddChild( StudentDTD.SCHEDULEINFOOVERRIDE_MEETINGTIMELIST, value );
			}
		}
	}

}}