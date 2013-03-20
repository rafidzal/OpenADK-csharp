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

/// <summary>A SupportingActivities</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class SupportingActivities : SifKeyedList<ActivityRefId>
{
	/// <summary>
	/// Creates an instance of a SupportingActivities
	/// </summary>
	public SupportingActivities() : base ( InstrDTD.SUPPORTINGACTIVITIES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="activityRefId">Links to Activity objects that may support the lesson</param>
	///
	public SupportingActivities( ActivityRefId activityRefId ) : base( InstrDTD.SUPPORTINGACTIVITIES )
	{
		this.SafeAddChild( InstrDTD.SUPPORTINGACTIVITIES_ACTIVITYREFID, activityRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SupportingActivities( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;ActivityRefId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;ActivityRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setActivityRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddActivityRefId</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void AddActivityRefId( string Value ) {
		AddChild( InstrDTD.SUPPORTINGACTIVITIES_ACTIVITYREFID, new ActivityRefId( Value ) );
	}

}}
