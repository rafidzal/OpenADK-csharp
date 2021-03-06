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

namespace OpenADK.Library.us.Programs{

/// <summary>A PartCTransitionMeetingNotHeldReason</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class PartCTransitionMeetingNotHeldReason : SifElement
{
	/// <summary>
	/// Creates an instance of a PartCTransitionMeetingNotHeldReason
	/// </summary>
	public PartCTransitionMeetingNotHeldReason() : base ( ProgramsDTD.PARTCTRANSITIONMEETINGNOTHELDREASON ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PartCTransitionMeetingNotHeldReason( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A reason why the Part C transition meeting was not held."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Code
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.PARTCTRANSITIONMEETINGNOTHELDREASON_CODE ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.PARTCTRANSITIONMEETINGNOTHELDREASON_CODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( ProgramsDTD.PARTCTRANSITIONMEETINGNOTHELDREASON_OTHERCODELIST);
		}
		set
		{
			RemoveChild( ProgramsDTD.PARTCTRANSITIONMEETINGNOTHELDREASON_OTHERCODELIST);
			if( value != null)
			{
				AddChild( ProgramsDTD.PARTCTRANSITIONMEETINGNOTHELDREASON_OTHERCODELIST, value );
			}
		}
	}

}}
