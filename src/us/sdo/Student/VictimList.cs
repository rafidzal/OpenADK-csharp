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

/// <summary>A VictimList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class VictimList : SifKeyedList<Victim>
{
	/// <summary>
	/// Creates an instance of a VictimList
	/// </summary>
	public VictimList() : base ( StudentDTD.VICTIMLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="victim">A Victim</param>
	///
	public VictimList( Victim victim ) : base( StudentDTD.VICTIMLIST )
	{
		this.SafeAddChild( StudentDTD.VICTIMLIST_VICTIM, victim );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected VictimList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;Victim&gt;</c> element.</summary>
	/// <param name="Type">Identifies the type of individual victimized in the incident.</param>
	///<remarks>
	/// <para>This form of <c>setVictim</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddVictim</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddVictim( ReporterDescriptionType Type ) {
		AddChild( StudentDTD.VICTIMLIST_VICTIM, new Victim( Type ) );
	}

}}
