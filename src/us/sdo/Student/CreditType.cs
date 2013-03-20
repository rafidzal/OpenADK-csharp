// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Student
{
	///<summary>
	/// Defines the set of values that can be specified whenever a CreditType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a CreditType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class CreditType : SifEnum
	{
	/// <summary>Converted occupational experience credit ("0601")</summary>
	public static readonly CreditType C0108_0601 = new CreditType("0601");

	/// <summary>Correspondence credit ("0600")</summary>
	public static readonly CreditType C0108_0600 = new CreditType("0600");

	/// <summary>Credit by examination ("0599")</summary>
	public static readonly CreditType C0108_0599 = new CreditType("0599");

	/// <summary>Adult education credit ("0598")</summary>
	public static readonly CreditType C0108_0598 = new CreditType("0598");

	/// <summary>Vocational credit ("0597")</summary>
	public static readonly CreditType C0108_0597 = new CreditType("0597");

	/// <summary>Twelve month hour credit ("0596")</summary>
	public static readonly CreditType C0108_0596 = new CreditType("0596");

	/// <summary>Long session hour credit ("0595")</summary>
	public static readonly CreditType C0108_0595 = new CreditType("0595");

	/// <summary>Intersession hour credit ("0592")</summary>
	public static readonly CreditType C0108_0592 = new CreditType("0592");

	/// <summary>Summer term hour credit ("0591")</summary>
	public static readonly CreditType C0108_0591 = new CreditType("0591");

	/// <summary>Quinmester hour credit ("0589")</summary>
	public static readonly CreditType C0108_0589 = new CreditType("0589");

	/// <summary>Quarter hour credit ("0588")</summary>
	public static readonly CreditType C0108_0588 = new CreditType("0588");

	/// <summary>Mini-term hour credit ("0590")</summary>
	public static readonly CreditType C0108_0590 = new CreditType("0590");

	/// <summary>Trimester hour credit ("0587")</summary>
	public static readonly CreditType C0108_0587 = new CreditType("0587");

	/// <summary>Semester hour credit ("0586")</summary>
	public static readonly CreditType C0108_0586 = new CreditType("0586");

	/// <summary>Other ("9999")</summary>
	public static readonly CreditType C0108_9999 = new CreditType("9999");

	/// <summary>Carnegie unit ("0585")</summary>
	public static readonly CreditType C0108_0585 = new CreditType("0585");

	/// <summary>None ("9998")</summary>
	public static readonly CreditType C0108_9998 = new CreditType("9998");

	///<summary>Wrap an arbitrary string value in a CreditType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static CreditType Wrap( String wrappedValue ) {
		return new CreditType( wrappedValue );
	}

	private CreditType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
