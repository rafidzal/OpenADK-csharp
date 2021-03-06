// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Library
{
	///<summary>
	/// Defines the set of values that can be specified whenever a Priority
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a Priority object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	[Serializable]
	public class Priority : SifEnum
	{
	/// <summary>Urgent ("Urgent")</summary>
	public static readonly Priority URGENT = new Priority("Urgent");

	/// <summary>Normal ("Normal")</summary>
	public static readonly Priority NORMAL = new Priority("Normal");

	/// <summary>Low ("Low")</summary>
	public static readonly Priority LOW = new Priority("Low");

	///<summary>Wrap an arbitrary string value in a Priority object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static Priority Wrap( String wrappedValue ) {
		return new Priority( wrappedValue );
	}

	private Priority( string enumDefValue ) : base( enumDefValue ) {}
	}
}
