// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Food
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SalesAmountType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SalesAmountType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class SalesAmountType : SifEnum
	{
	/// <summary>Account ("Account")</summary>
	public static readonly SalesAmountType ACCOUNT = new SalesAmountType("Account");

	/// <summary>Charged ("Charged")</summary>
	public static readonly SalesAmountType CHARGED = new SalesAmountType("Charged");

	/// <summary>Cash ("Cash")</summary>
	public static readonly SalesAmountType CASH = new SalesAmountType("Cash");

	/// <summary>Earned ("Earned")</summary>
	public static readonly SalesAmountType EARNED = new SalesAmountType("Earned");

	///<summary>Wrap an arbitrary string value in a SalesAmountType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SalesAmountType Wrap( String wrappedValue ) {
		return new SalesAmountType( wrappedValue );
	}

	private SalesAmountType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
