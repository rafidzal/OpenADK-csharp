// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Etranscripts
{
	///<summary>
	/// Defines the set of values that can be specified whenever an HonorsInformationCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an HonorsInformationCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class HonorsInformationCode : SifEnum
	{
	/// <summary>Promotion or advancement ("0748")</summary>
	public static readonly HonorsInformationCode PROMOTION = new HonorsInformationCode("0748");

	/// <summary>Scholarships ("1991")</summary>
	public static readonly HonorsInformationCode SCHOLARSHIPS = new HonorsInformationCode("1991");

	/// <summary>Medals ("0745")</summary>
	public static readonly HonorsInformationCode MEDALS = new HonorsInformationCode("0745");

	/// <summary>Ranks ("1990")</summary>
	public static readonly HonorsInformationCode RANKS = new HonorsInformationCode("1990");

	/// <summary>Certificate ("0742")</summary>
	public static readonly HonorsInformationCode CERTIFICATE = new HonorsInformationCode("0742");

	/// <summary>Honor award ("2047")</summary>
	public static readonly HonorsInformationCode HONOR_AWARD = new HonorsInformationCode("2047");

	/// <summary>Honor society ("1986")</summary>
	public static readonly HonorsInformationCode HONOR_SOCIETY = new HonorsInformationCode("1986");

	/// <summary>Prize awards ("1989")</summary>
	public static readonly HonorsInformationCode PRIZE_AWARDS = new HonorsInformationCode("1989");

	/// <summary>Points ("0747")</summary>
	public static readonly HonorsInformationCode POINTS = new HonorsInformationCode("0747");

	/// <summary>Monogram/letter ("0746")</summary>
	public static readonly HonorsInformationCode MONOGRAM_LETTER = new HonorsInformationCode("0746");

	/// <summary>Awarding of units of value ("0738")</summary>
	public static readonly HonorsInformationCode AWARDING_UNITS_VALUE = new HonorsInformationCode("0738");

	/// <summary>Completion of requirement, but no units of value awarded ("0741")</summary>
	public static readonly HonorsInformationCode COMPLETION_NO_UNITS = new HonorsInformationCode("0741");

	/// <summary>Honors program ("1988")</summary>
	public static readonly HonorsInformationCode HONORS_PROGRAM = new HonorsInformationCode("1988");

	/// <summary>Honorable mention ("1987")</summary>
	public static readonly HonorsInformationCode HONORABLE_MENTION = new HonorsInformationCode("1987");

	/// <summary>Athletic awards ("0737")</summary>
	public static readonly HonorsInformationCode ATHLETIC = new HonorsInformationCode("0737");

	/// <summary>Letter of student commendation ("0744")</summary>
	public static readonly HonorsInformationCode LETTER_COMMENDATION = new HonorsInformationCode("0744");

	/// <summary>Other ("9999")</summary>
	public static readonly HonorsInformationCode OTHER = new HonorsInformationCode("9999");

	/// <summary>Citizenship award/recognition ("0740")</summary>
	public static readonly HonorsInformationCode CITIZENSHIP_AWARD = new HonorsInformationCode("0740");

	/// <summary>Honor roll ("1985")</summary>
	public static readonly HonorsInformationCode HONOR_ROLL = new HonorsInformationCode("1985");

	///<summary>Wrap an arbitrary string value in an HonorsInformationCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static HonorsInformationCode Wrap( String wrappedValue ) {
		return new HonorsInformationCode( wrappedValue );
	}

	private HonorsInformationCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}
