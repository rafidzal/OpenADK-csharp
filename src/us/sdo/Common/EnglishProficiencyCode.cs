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
	/// Defines the set of values that can be specified whenever an EnglishProficiencyCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an EnglishProficiencyCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	[Serializable]
	public class EnglishProficiencyCode : SifEnum
	{
	/// <summary>Status unknown ("1637")</summary>
	public static readonly EnglishProficiencyCode STATUS_UNKNOWN = new EnglishProficiencyCode("1637");

	/// <summary>Redesignated as fluent English proficient  ("05 ")</summary>
	public static readonly EnglishProficiencyCode SIF15_REDESIGNATED_AS_FLUENT = new EnglishProficiencyCode("05 ");

	/// <summary>Non-English speaking  ("04 ")</summary>
	public static readonly EnglishProficiencyCode SIF15_NON_ENGLISH_SPEAKING = new EnglishProficiencyCode("04 ");

	/// <summary>Redesignated as fluent English proficient ("1636")</summary>
	public static readonly EnglishProficiencyCode REDESIGNATED_AS_FLUENT = new EnglishProficiencyCode("1636");

	/// <summary>Limited English proficient/English language learner ("2349")</summary>
	public static readonly EnglishProficiencyCode LIMITED_ENGLISH = new EnglishProficiencyCode("2349");

	/// <summary>Native English speaker ("1633")</summary>
	public static readonly EnglishProficiencyCode NATIVE_ENGLISH = new EnglishProficiencyCode("1633");

	/// <summary>Fluent English proficient  ("02 ")</summary>
	public static readonly EnglishProficiencyCode SIF15_FLUENT_ENGLISH = new EnglishProficiencyCode("02 ");

	/// <summary>Non-English speaking ("1635")</summary>
	public static readonly EnglishProficiencyCode NON_ENGLISH_SPEAKING = new EnglishProficiencyCode("1635");

	/// <summary>Status unknown ("99 ")</summary>
	public static readonly EnglishProficiencyCode SIF15_STATUS_UNKNOWN = new EnglishProficiencyCode("99 ");

	/// <summary>Fluent English speaker ("1634")</summary>
	public static readonly EnglishProficiencyCode FLUENT_ENGLISH = new EnglishProficiencyCode("1634");

	/// <summary>Limited English proficient/English language learner  ("03 ")</summary>
	public static readonly EnglishProficiencyCode SIF15_LIMITED_ENGLISH = new EnglishProficiencyCode("03 ");

	/// <summary>Native English speaker  ("01 ")</summary>
	public static readonly EnglishProficiencyCode SIF15_NATIVE_ENGLISH_SPEAKER = new EnglishProficiencyCode("01 ");

	///<summary>Wrap an arbitrary string value in an EnglishProficiencyCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static EnglishProficiencyCode Wrap( String wrappedValue ) {
		return new EnglishProficiencyCode( wrappedValue );
	}

	private EnglishProficiencyCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}
