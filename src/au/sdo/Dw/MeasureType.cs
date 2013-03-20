// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Dw
{
	///<summary>
	/// Defines the set of values that can be specified whenever a MeasureType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a MeasureType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	[Serializable]
	public class MeasureType : SifEnum
	{
	/// <summary>Minimum ("Minimum")</summary>
	public static readonly MeasureType MINIMUM = new MeasureType("Minimum");

	/// <summary>Sum ("Sum")</summary>
	public static readonly MeasureType SUM = new MeasureType("Sum");

	/// <summary>Count ("Count")</summary>
	public static readonly MeasureType COUNT = new MeasureType("Count");

	/// <summary>Percent ("Percent")</summary>
	public static readonly MeasureType PERCENT = new MeasureType("Percent");

	/// <summary>Other ("Other")</summary>
	public static readonly MeasureType OTHER = new MeasureType("Other");

	/// <summary>Mode ("Mode")</summary>
	public static readonly MeasureType MODE = new MeasureType("Mode");

	/// <summary>Maximum ("Maximum")</summary>
	public static readonly MeasureType MAXIMUM = new MeasureType("Maximum");

	/// <summary>StandardDeviation ("StandardDeviation")</summary>
	public static readonly MeasureType STANDARDDEVIATION = new MeasureType("StandardDeviation");

	/// <summary>Median ("Median")</summary>
	public static readonly MeasureType MEDIAN = new MeasureType("Median");

	/// <summary>Mean ("Mean")</summary>
	public static readonly MeasureType MEAN = new MeasureType("Mean");

	/// <summary>UnduplicatedCount ("UnduplicatedCount")</summary>
	public static readonly MeasureType UNDUPLICATEDCOUNT = new MeasureType("UnduplicatedCount");

	/// <summary>FTE ("FTE")</summary>
	public static readonly MeasureType FTE = new MeasureType("FTE");

	///<summary>Wrap an arbitrary string value in a MeasureType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static MeasureType Wrap( String wrappedValue ) {
		return new MeasureType( wrappedValue );
	}

	private MeasureType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
