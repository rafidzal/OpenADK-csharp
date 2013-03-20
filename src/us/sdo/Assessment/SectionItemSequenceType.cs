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
	/// Defines the set of values that can be specified whenever a SectionItemSequenceType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SectionItemSequenceType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class SectionItemSequenceType : SifEnum
	{
	/// <summary>other ("other")</summary>
	public static readonly SectionItemSequenceType OTHER = new SectionItemSequenceType("other");

	/// <summary>random ("random")</summary>
	public static readonly SectionItemSequenceType RANDOM = new SectionItemSequenceType("random");

	/// <summary>sequential ("sequential")</summary>
	public static readonly SectionItemSequenceType SEQUENTIAL = new SectionItemSequenceType("sequential");

	/// <summary>adaptive ("adaptive")</summary>
	public static readonly SectionItemSequenceType ADAPTIVE = new SectionItemSequenceType("adaptive");

	///<summary>Wrap an arbitrary string value in a SectionItemSequenceType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SectionItemSequenceType Wrap( String wrappedValue ) {
		return new SectionItemSequenceType( wrappedValue );
	}

	private SectionItemSequenceType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
