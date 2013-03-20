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

namespace OpenADK.Library.Infra{

/// <summary>The password in this system for this user.  Value must be base64 encoded to facilitate transfer of possibly invalid XML characters that can result from the encryption algorithm applied, and to deter casual snooping of unencrypted passwords.  An Algorithm attribute value of "base64" therefore signifies clear text.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class Password : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Password
	/// </summary>
	public Password() : base ( InfraDTD.PASSWORD ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="algorithm">The method used to encrypt the user's password. See the implementation details below.</param>
	///<param name="keyName">The name of the key to be used for decryption of the password.  Left blank for plain, encoded text (Algorithm attribute value of "base64") and hash algorithms.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;Password&amp;gt; element</param>
	///
	public Password( PasswordAlgorithm algorithm, string keyName, string value ) : base( InfraDTD.PASSWORD )
	{
		this.SetAlgorithm( algorithm );
		this.KeyName = keyName;
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Password( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.PASSWORD_ALGORITHM }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Password&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;Password&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.PASSWORD ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.PASSWORD, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Algorithm</c> attribute.
	/// </summary>
	/// <value> The <c>Algorithm</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The method used to encrypt the user's password. See the implementation details below."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Algorithm
	{
		get
		{ 
			return GetFieldValue( InfraDTD.PASSWORD_ALGORITHM );
		}
		set
		{
			SetField( InfraDTD.PASSWORD_ALGORITHM, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Algorithm</c> attribute.
	/// </summary>
	/// <param name="val">A PasswordAlgorithm object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The method used to encrypt the user's password. See the implementation details below."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetAlgorithm( PasswordAlgorithm val )
	{
		SetField( InfraDTD.PASSWORD_ALGORITHM, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>KeyName</c> attribute.
	/// </summary>
	/// <value> The <c>KeyName</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The name of the key to be used for decryption of the password.  Left blank for plain, encoded text (Algorithm attribute value of "base64") and hash algorithms."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string KeyName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.PASSWORD_KEYNAME ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.PASSWORD_KEYNAME, new SifString( value ), value );
		}
	}

}}
