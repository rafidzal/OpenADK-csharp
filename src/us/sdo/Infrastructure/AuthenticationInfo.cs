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
using OpenADK.Library.Infra;
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Infrastructure{

/// <summary>The authentication information for one system.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class AuthenticationInfo : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an AuthenticationInfo
	/// </summary>
	public AuthenticationInfo() : base ( InfrastructureDTD.AUTHENTICATIONINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="system">An identifying string for the system that supports this authentication information.</param>
	///
	public AuthenticationInfo( AuthSystem system ) : base( InfrastructureDTD.AUTHENTICATIONINFO )
	{
		this.System = system;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AuthenticationInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InfrastructureDTD.AUTHENTICATIONINFO_SYSTEM }; }
	}

	///<summary>Sets the value of the <c>&lt;System&gt;</c> element.</summary>
	/// <param name="Type">Specific type of user identification.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;AuthSystem&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setSystem</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>System</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetSystem( AuthSystemType Type, string Value ) {
		RemoveChild( InfrastructureDTD.AUTHENTICATIONINFO_SYSTEM);
		AddChild( InfrastructureDTD.AUTHENTICATIONINFO_SYSTEM, new AuthSystem( Type, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;System&gt;</c> element.
	/// </summary>
	/// <value> An AuthSystem </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "An identifying string for the system that supports this authentication information."</para>
	/// <para>To remove the <c>AuthSystem</c>, set <c>System</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public AuthSystem System
	{
		get
		{
			return (AuthSystem)GetChild( InfrastructureDTD.AUTHENTICATIONINFO_SYSTEM);
		}
		set
		{
			RemoveChild( InfrastructureDTD.AUTHENTICATIONINFO_SYSTEM);
			if( value != null)
			{
				AddChild( InfrastructureDTD.AUTHENTICATIONINFO_SYSTEM, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Username&gt;</c> element.
	/// </summary>
	/// <value> The <c>Username</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The identification string for this user."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Username
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfrastructureDTD.AUTHENTICATIONINFO_USERNAME ) ;
		}
		set
		{
			SetFieldValue( InfrastructureDTD.AUTHENTICATIONINFO_USERNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DistinguishedName&gt;</c> element.
	/// </summary>
	/// <value> The <c>DistinguishedName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This is the distinguished name of the user in a network directory system."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string DistinguishedName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfrastructureDTD.AUTHENTICATIONINFO_DISTINGUISHEDNAME ) ;
		}
		set
		{
			SetFieldValue( InfrastructureDTD.AUTHENTICATIONINFO_DISTINGUISHEDNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PasswordList&gt;</c> element.
	/// </summary>
	/// <value> A PasswordList </value>
	/// <remarks>
	/// <para>To remove the <c>PasswordList</c>, set <c>PasswordList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public PasswordList PasswordList
	{
		get
		{
			return (PasswordList)GetChild( InfrastructureDTD.AUTHENTICATIONINFO_PASSWORDLIST);
		}
		set
		{
			RemoveChild( InfrastructureDTD.AUTHENTICATIONINFO_PASSWORDLIST);
			if( value != null)
			{
				AddChild( InfrastructureDTD.AUTHENTICATIONINFO_PASSWORDLIST, value );
			}
		}
	}

}}
