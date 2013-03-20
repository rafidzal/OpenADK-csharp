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
	/// Defines the set of values that can be specified whenever a SpecialisedResources
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SpecialisedResources object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class SpecialisedResources : SifEnum
	{
	/// <summary>Periodic access to standard equipment ("SR1")</summary>
	public static readonly SpecialisedResources PERIODIC_ACCESS_STANDARD = new SpecialisedResources("SR1");

	/// <summary>Individual access to specialised equipment ("SR3")</summary>
	public static readonly SpecialisedResources IND_ACCESS_SPECIALISED = new SpecialisedResources("SR3");

	/// <summary>Dedicated access to highly specialised equipment ("SR4")</summary>
	public static readonly SpecialisedResources ACCESS_HIGHLY_SPECIALISED = new SpecialisedResources("SR4");

	/// <summary>Individual access to normally available equipment ("SR2")</summary>
	public static readonly SpecialisedResources IND_ACCESS_NORMAL = new SpecialisedResources("SR2");

	///<summary>Wrap an arbitrary string value in a SpecialisedResources object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SpecialisedResources Wrap( String wrappedValue ) {
		return new SpecialisedResources( wrappedValue );
	}

	private SpecialisedResources( string enumDefValue ) : base( enumDefValue ) {}
	}
}
