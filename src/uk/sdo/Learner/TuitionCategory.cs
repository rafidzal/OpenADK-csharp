// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Learner
{
	///<summary>
	/// Defines the set of values that can be specified whenever a TuitionCategory
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a TuitionCategory object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class TuitionCategory : SifEnum
	{
	/// <summary>Alternative Tuition at Home by Parents/Carers ("HP")</summary>
	public static readonly TuitionCategory HOME = new TuitionCategory("HP");

	/// <summary>Alternative Tuition by LA for Other Reason ("OR")</summary>
	public static readonly TuitionCategory LA_OTHER = new TuitionCategory("OR");

	/// <summary>Alternative Tuition by LA because of Permanent Exclusion ("PE")</summary>
	public static readonly TuitionCategory LA_EXCLUSION = new TuitionCategory("PE");

	/// <summary>Alternative Tuition by LA because of Illness ("IL")</summary>
	public static readonly TuitionCategory LA_ILLNESS = new TuitionCategory("IL");

	///<summary>Wrap an arbitrary string value in a TuitionCategory object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static TuitionCategory Wrap( String wrappedValue ) {
		return new TuitionCategory( wrappedValue );
	}

	private TuitionCategory( string enumDefValue ) : base( enumDefValue ) {}
	}
}
