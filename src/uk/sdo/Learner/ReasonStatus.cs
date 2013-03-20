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
	/// Defines the set of values that can be specified whenever a ReasonStatus
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a ReasonStatus object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class ReasonStatus : SifEnum
	{
	/// <summary>Authorised ("Authorised")</summary>
	public static readonly ReasonStatus AUTHORISED = new ReasonStatus("Authorised");

	/// <summary>Not Applicable ("NA")</summary>
	public static readonly ReasonStatus NA = new ReasonStatus("NA");

	/// <summary>Unknown ("Unknown")</summary>
	public static readonly ReasonStatus UNKNOWN = new ReasonStatus("Unknown");

	/// <summary>Unauthorised ("Unauthorised")</summary>
	public static readonly ReasonStatus UNAUTHORISED = new ReasonStatus("Unauthorised");

	///<summary>Wrap an arbitrary string value in a ReasonStatus object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static ReasonStatus Wrap( String wrappedValue ) {
		return new ReasonStatus( wrappedValue );
	}

	private ReasonStatus( string enumDefValue ) : base( enumDefValue ) {}
	}
}
