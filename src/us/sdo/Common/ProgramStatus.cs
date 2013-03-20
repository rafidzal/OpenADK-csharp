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

namespace OpenADK.Library.us.Common{

/// <summary>A ProgramStatus</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class ProgramStatus : SifElement
{
	/// <summary>
	/// Creates an instance of a ProgramStatus
	/// </summary>
	public ProgramStatus() : base ( CommonDTD.PROGRAMSTATUS ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ProgramStatus( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The current status of the student's program participation."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( CommonDTD.PROGRAMSTATUS_CODE );
		}
		set
		{
			SetField( CommonDTD.PROGRAMSTATUS_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A ProgramStatusCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The current status of the student's program participation."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetCode( ProgramStatusCode val )
	{
		SetField( CommonDTD.PROGRAMSTATUS_CODE, val );
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
			return (OtherCodeList)GetChild( CommonDTD.PROGRAMSTATUS_OTHERCODELIST);
		}
		set
		{
			RemoveChild( CommonDTD.PROGRAMSTATUS_OTHERCODELIST);
			if( value != null)
			{
				AddChild( CommonDTD.PROGRAMSTATUS_OTHERCODELIST, value );
			}
		}
	}

}}
