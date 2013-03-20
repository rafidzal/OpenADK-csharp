// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Instr
{
	///<summary>
	/// Defines the set of values that can be specified whenever a TimeUnits
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a TimeUnits object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class TimeUnits : SifEnum
	{
	/// <summary>Second ("Second")</summary>
	public static readonly TimeUnits SECOND = new TimeUnits("Second");

	/// <summary>Hour ("Hour")</summary>
	public static readonly TimeUnits HOUR = new TimeUnits("Hour");

	/// <summary>Minute ("Minute")</summary>
	public static readonly TimeUnits MINUTE = new TimeUnits("Minute");

	/// <summary>Week ("Week")</summary>
	public static readonly TimeUnits WEEK = new TimeUnits("Week");

	/// <summary>Day ("Day")</summary>
	public static readonly TimeUnits DAY = new TimeUnits("Day");

	///<summary>Wrap an arbitrary string value in a TimeUnits object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static TimeUnits Wrap( String wrappedValue ) {
		return new TimeUnits( wrappedValue );
	}

	private TimeUnits( string enumDefValue ) : base( enumDefValue ) {}
	}
}
