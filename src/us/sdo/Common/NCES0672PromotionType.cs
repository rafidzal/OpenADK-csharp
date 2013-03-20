// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a NCES0672PromotionType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a NCES0672PromotionType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	[Serializable]
	public class NCES0672PromotionType : SifEnum
	{
	/// <summary>Other ("9999")</summary>
	public static readonly NCES0672PromotionType OTHER = new NCES0672PromotionType("9999");

	/// <summary>Probationary promotion ("1976")</summary>
	public static readonly NCES0672PromotionType PROBATIONARY_PROMOTION = new NCES0672PromotionType("1976");

	/// <summary>Continuous promotion ("1975")</summary>
	public static readonly NCES0672PromotionType CONTINUOUS_PROMOTION = new NCES0672PromotionType("1975");

	/// <summary>Regular promotion ("1973")</summary>
	public static readonly NCES0672PromotionType REGULAR_PROMOTION = new NCES0672PromotionType("1973");

	/// <summary>Accelerated promotion ("1974")</summary>
	public static readonly NCES0672PromotionType ACCELERATED_PROMOTION = new NCES0672PromotionType("1974");

	/// <summary>Variable progress ("1978")</summary>
	public static readonly NCES0672PromotionType VARIABLE_PROGRESS = new NCES0672PromotionType("1978");

	/// <summary>Social promotion ("1977")</summary>
	public static readonly NCES0672PromotionType SOCIAL_PROMOTION = new NCES0672PromotionType("1977");

	///<summary>Wrap an arbitrary string value in a NCES0672PromotionType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static NCES0672PromotionType Wrap( String wrappedValue ) {
		return new NCES0672PromotionType( wrappedValue );
	}

	private NCES0672PromotionType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
