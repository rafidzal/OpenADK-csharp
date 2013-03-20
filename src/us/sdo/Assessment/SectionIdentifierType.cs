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
	/// Defines the set of values that can be specified whenever a SectionIdentifierType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SectionIdentifierType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class SectionIdentifierType : SifEnum
	{
	/// <summary>Custom ("other")</summary>
	public static readonly SectionIdentifierType OTHER = new SectionIdentifierType("other");

	/// <summary>Assigned by the owner ("publisher")</summary>
	public static readonly SectionIdentifierType PUBLISHER = new SectionIdentifierType("publisher");

	/// <summary>internal assessment provider identifier ("internal")</summary>
	public static readonly SectionIdentifierType INTERNAL = new SectionIdentifierType("internal");

	/// <summary>assigned by the client; generally a smart number that indicates grade, subject, etc. ("client")</summary>
	public static readonly SectionIdentifierType CLIENT = new SectionIdentifierType("client");

	///<summary>Wrap an arbitrary string value in a SectionIdentifierType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SectionIdentifierType Wrap( String wrappedValue ) {
		return new SectionIdentifierType( wrappedValue );
	}

	private SectionIdentifierType( string enumDefValue ) : base( enumDefValue ) {}
	}
}