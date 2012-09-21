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

/// <summary>A PasswordList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class PasswordList : SifKeyedList<Password>
{
	/// <summary>
	/// Creates an instance of a PasswordList
	/// </summary>
	public PasswordList() : base ( InfrastructureDTD.PASSWORDLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="password">A representation of the user's password using the given algorithm.</param>
	///
	public PasswordList( Password password ) : base( InfrastructureDTD.PASSWORDLIST )
	{
		this.SafeAddChild( InfrastructureDTD.PASSWORDLIST_PASSWORD, password );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PasswordList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;Password&gt;</c> element.</summary>
	/// <param name="Algorithm">The method used to encrypt the user's password. See the implementation details below.</param>
	/// <param name="KeyName">The name of the key to be used for decryption of the password.  Left blank for plain, encoded text (Algorithm attribute value of "base64") and hash algorithms.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Password&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setPassword</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddPassword</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void AddPassword( PasswordAlgorithm Algorithm, string KeyName, string Value ) {
		AddChild( InfrastructureDTD.PASSWORDLIST_PASSWORD, new Password( Algorithm, KeyName, Value ) );
	}

}}