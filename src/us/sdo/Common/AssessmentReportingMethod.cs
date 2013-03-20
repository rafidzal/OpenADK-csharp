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
	/// Defines the set of values that can be specified whenever an AssessmentReportingMethod
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AssessmentReportingMethod object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class AssessmentReportingMethod : SifEnum
	{
	/// <summary>Stanine score ("0508")</summary>
	public static readonly AssessmentReportingMethod STANINE = new AssessmentReportingMethod("0508");

	/// <summary>Percentile rank ("0502")</summary>
	public static readonly AssessmentReportingMethod PERCENTILE_RANK = new AssessmentReportingMethod("0502");

	/// <summary>Mastery level ("0513")</summary>
	public static readonly AssessmentReportingMethod MASTERY_LEVEL = new AssessmentReportingMethod("0513");

	/// <summary>Normalized standard score ("0498")</summary>
	public static readonly AssessmentReportingMethod NORMALIZED_STANDARD = new AssessmentReportingMethod("0498");

	/// <summary>CEEB-scores ("0492")</summary>
	public static readonly AssessmentReportingMethod CEEB = new AssessmentReportingMethod("0492");

	/// <summary>Standard age score ("0506")</summary>
	public static readonly AssessmentReportingMethod STANDARD_AGE = new AssessmentReportingMethod("0506");

	/// <summary>Letter grade/Mark ("0144")</summary>
	public static readonly AssessmentReportingMethod LETTER_MARK = new AssessmentReportingMethod("0144");

	/// <summary>ITED-score ("0494")</summary>
	public static readonly AssessmentReportingMethod ITED = new AssessmentReportingMethod("0494");

	/// <summary>Achievement level ("0512")</summary>
	public static readonly AssessmentReportingMethod ACHIEVEMENT_LEVEL = new AssessmentReportingMethod("0512");

	/// <summary>C-scaled scores ("0491")</summary>
	public static readonly AssessmentReportingMethod C_SCALED = new AssessmentReportingMethod("0491");

	/// <summary>Grade equivalent or grade-level indicator ("0493")</summary>
	public static readonly AssessmentReportingMethod GRADE_EQUIV = new AssessmentReportingMethod("0493");

	/// <summary>Number score ("0499")</summary>
	public static readonly AssessmentReportingMethod NUMBER = new AssessmentReportingMethod("0499");

	/// <summary>Z-score ("0511")</summary>
	public static readonly AssessmentReportingMethod Z_SCORE = new AssessmentReportingMethod("0511");

	/// <summary>Sten score ("0509")</summary>
	public static readonly AssessmentReportingMethod STEN = new AssessmentReportingMethod("0509");

	/// <summary>Age score ("0490")</summary>
	public static readonly AssessmentReportingMethod AGE_SCORE = new AssessmentReportingMethod("0490");

	/// <summary>Ranking ("0504")</summary>
	public static readonly AssessmentReportingMethod RANKING = new AssessmentReportingMethod("0504");

	/// <summary>Other ("9999")</summary>
	public static readonly AssessmentReportingMethod OTHER = new AssessmentReportingMethod("9999");

	/// <summary>Normal curve equivalent ("0497")</summary>
	public static readonly AssessmentReportingMethod NORMAL_CURVE = new AssessmentReportingMethod("0497");

	/// <summary>Pass-Fail ("0500")</summary>
	public static readonly AssessmentReportingMethod PASS_FAIL = new AssessmentReportingMethod("0500");

	/// <summary>Proficiency level ("0503")</summary>
	public static readonly AssessmentReportingMethod PROFICIENCY_LEVEL = new AssessmentReportingMethod("0503");

	/// <summary>Ratio IQ's ("0505")</summary>
	public static readonly AssessmentReportingMethod RATIO_IQ = new AssessmentReportingMethod("0505");

	/// <summary>T-score ("0510")</summary>
	public static readonly AssessmentReportingMethod T_SCORE = new AssessmentReportingMethod("0510");

	///<summary>Wrap an arbitrary string value in an AssessmentReportingMethod object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AssessmentReportingMethod Wrap( String wrappedValue ) {
		return new AssessmentReportingMethod( wrappedValue );
	}

	private AssessmentReportingMethod( string enumDefValue ) : base( enumDefValue ) {}
	}
}
