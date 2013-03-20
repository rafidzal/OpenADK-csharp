// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Sif3assessment
{
	///<summary>
	/// Defines the set of values that can be specified whenever a PassFailEnum
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a PassFailEnum object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class PassFailEnum : SifEnum
	{
	/// <summary>Pass ("p")</summary>
	public static readonly PassFailEnum PASS = new PassFailEnum("p");

	/// <summary>Fail ("f")</summary>
	public static readonly PassFailEnum FAIL = new PassFailEnum("f");

	///<summary>Wrap an arbitrary string value in a PassFailEnum object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static PassFailEnum Wrap( String wrappedValue ) {
		return new PassFailEnum( wrappedValue );
	}

	private PassFailEnum( string enumDefValue ) : base( enumDefValue ) {}
	}
}
