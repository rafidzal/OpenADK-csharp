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

/// <summary>A StaffPersonalData</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class StaffPersonalData : SifElement
{
	/// <summary>
	/// Creates an instance of a StaffPersonalData
	/// </summary>
	public StaffPersonalData() : base ( EtranscriptsDTD.STAFFPERSONALDATA ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StaffPersonalData( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Sets the value of the <c>&lt;Name&gt;</c> element.</summary>
	/// <param name="Type">Code that specifies what type of name this is.  If unsure, use 04.</param>
	/// <param name="LastName">The last name.</param>
	/// <param name="FirstName">The first name.</param>
	///<remarks>
	/// <para>This form of <c>setName</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Name</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetName( NameType Type, string LastName, string FirstName ) {
		RemoveChild( EtranscriptsDTD.STAFFPERSONALDATA_NAME);
		AddChild( EtranscriptsDTD.STAFFPERSONALDATA_NAME, new Name( Type, LastName, FirstName ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> A Name </value>
	/// <remarks>
	/// <para>To remove the <c>Name</c>, set <c>Name</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Name Name
	{
		get
		{
			return (Name)GetChild( EtranscriptsDTD.STAFFPERSONALDATA_NAME);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STAFFPERSONALDATA_NAME);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STAFFPERSONALDATA_NAME, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Title&gt;</c> element.
	/// </summary>
	/// <value> The <c>Title</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Title
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.STAFFPERSONALDATA_TITLE ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.STAFFPERSONALDATA_TITLE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AddressList&gt;</c> element.
	/// </summary>
	/// <value> An AddressList </value>
	/// <remarks>
	/// <para>To remove the <c>AddressList</c>, set <c>AddressList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public AddressList AddressList
	{
		get
		{
			return (AddressList)GetChild( EtranscriptsDTD.STAFFPERSONALDATA_ADDRESSLIST);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STAFFPERSONALDATA_ADDRESSLIST);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STAFFPERSONALDATA_ADDRESSLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PhoneNumberList&gt;</c> element.
	/// </summary>
	/// <value> A PhoneNumberList </value>
	/// <remarks>
	/// <para>To remove the <c>PhoneNumberList</c>, set <c>PhoneNumberList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public PhoneNumberList PhoneNumberList
	{
		get
		{
			return (PhoneNumberList)GetChild( EtranscriptsDTD.STAFFPERSONALDATA_PHONENUMBERLIST);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STAFFPERSONALDATA_PHONENUMBERLIST);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STAFFPERSONALDATA_PHONENUMBERLIST, value );
			}
		}
	}

}}