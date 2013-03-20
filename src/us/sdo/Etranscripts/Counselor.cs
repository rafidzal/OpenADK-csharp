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
using OpenADK.Library.us.Gradebook;
using OpenADK.Library.us.Student;

namespace OpenADK.Library.us.Etranscripts{

/// <summary>A Counselor</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Counselor : SifElement
{
	/// <summary>
	/// Creates an instance of a Counselor
	/// </summary>
	public Counselor() : base ( EtranscriptsDTD.COUNSELOR ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Counselor( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;StaffPersonalData&gt;</c> element.
	/// </summary>
	/// <value> A StaffPersonalData </value>
	/// <remarks>
	/// <para>To remove the <c>StaffPersonalData</c>, set <c>StaffPersonalData</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public StaffPersonalData StaffPersonalData
	{
		get
		{
			return (StaffPersonalData)GetChild( EtranscriptsDTD.COUNSELOR_STAFFPERSONALDATA);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.COUNSELOR_STAFFPERSONALDATA);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.COUNSELOR_STAFFPERSONALDATA, value );
			}
		}
	}

}}
