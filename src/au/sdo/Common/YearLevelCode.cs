// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a YearLevelCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a YearLevelCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class YearLevelCode : SifEnum
	{
	/// <summary>Year 4 ("4")</summary>
	public static readonly YearLevelCode C4_YEAR_4 = new YearLevelCode("4");

	/// <summary>Year 13 ("13")</summary>
	public static readonly YearLevelCode C13_YEAR_13 = new YearLevelCode("13");

	/// <summary>Year 1 ("1")</summary>
	public static readonly YearLevelCode C1_YEAR_1 = new YearLevelCode("1");

	/// <summary>Year 11 ("11")</summary>
	public static readonly YearLevelCode C11_YEAR_11 = new YearLevelCode("11");

	/// <summary>Year 10 ("10")</summary>
	public static readonly YearLevelCode C10_YEAR_10 = new YearLevelCode("10");

	/// <summary>Ungraded ("UG")</summary>
	public static readonly YearLevelCode UG_UNGRADED = new YearLevelCode("UG");

	/// <summary>Kindergarten ("K")</summary>
	public static readonly YearLevelCode K_KINDERGARTEN = new YearLevelCode("K");

	/// <summary>Prep ("P")</summary>
	public static readonly YearLevelCode P_PREP = new YearLevelCode("P");

	/// <summary>3yo Kindergarten ("K3")</summary>
	public static readonly YearLevelCode C3YO_KINDERGARTEN = new YearLevelCode("K3");

	/// <summary>Year 7 ("7")</summary>
	public static readonly YearLevelCode C7_YEAR_7 = new YearLevelCode("7");

	/// <summary>Year 8 ("8")</summary>
	public static readonly YearLevelCode C8_YEAR_8 = new YearLevelCode("8");

	/// <summary>Childcare ("CC")</summary>
	public static readonly YearLevelCode CHILDCARE = new YearLevelCode("CC");

	/// <summary>Year 5 ("5")</summary>
	public static readonly YearLevelCode C5_YEAR_5 = new YearLevelCode("5");

	/// <summary>Year 2 ("2")</summary>
	public static readonly YearLevelCode C2_YEAR_2 = new YearLevelCode("2");

	/// <summary>Year 12 ("12")</summary>
	public static readonly YearLevelCode C12_YEAR_12 = new YearLevelCode("12");

	/// <summary>Year 3 ("3")</summary>
	public static readonly YearLevelCode C3_YEAR_3 = new YearLevelCode("3");

	/// <summary>4yo Kindergarten ("K4")</summary>
	public static readonly YearLevelCode C4YO_KINDERGARTEN = new YearLevelCode("K4");

	/// <summary>Year 9 ("9")</summary>
	public static readonly YearLevelCode C9_YEAR_9 = new YearLevelCode("9");

	/// <summary>Year 6 ("6")</summary>
	public static readonly YearLevelCode C6_YEAR_6 = new YearLevelCode("6");

	/// <summary>Pre-School ("PS")</summary>
	public static readonly YearLevelCode PS_PRESCHOOL = new YearLevelCode("PS");

	///<summary>Wrap an arbitrary string value in a YearLevelCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static YearLevelCode Wrap( String wrappedValue ) {
		return new YearLevelCode( wrappedValue );
	}

	private YearLevelCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}
