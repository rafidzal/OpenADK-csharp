// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Assessment
{
	///<summary>
	/// Defines the set of values that can be specified whenever a FormIdentifierType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a FormIdentifierType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class FormIdentifierType : SifEnum
	{
	/// <summary>custom identifier ("other")</summary>
	public static readonly FormIdentifierType OTHER = new FormIdentifierType("other");

	/// <summary>assigned by the asset owner ("publisher")</summary>
	public static readonly FormIdentifierType PUBLISHER = new FormIdentifierType("publisher");

	/// <summary>provided by an internal assessment service ("internal")</summary>
	public static readonly FormIdentifierType INTERNAL = new FormIdentifierType("internal");

	/// <summary>assigned by the client ("client")</summary>
	public static readonly FormIdentifierType CLIENT = new FormIdentifierType("client");

	///<summary>Wrap an arbitrary string value in a FormIdentifierType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static FormIdentifierType Wrap( String wrappedValue ) {
		return new FormIdentifierType( wrappedValue );
	}

	private FormIdentifierType( string enumDefValue ) : base( enumDefValue ) {}
	}
}