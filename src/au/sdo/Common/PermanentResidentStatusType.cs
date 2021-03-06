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
	/// Defines the set of values that can be specified whenever a PermanentResidentStatusType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a PermanentResidentStatusType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class PermanentResidentStatusType : SifEnum
	{
	/// <summary>Permanent Resident ("P")</summary>
	public static readonly PermanentResidentStatusType P_PERMANENT_RESIDENT = new PermanentResidentStatusType("P");

	/// <summary>Not a Resident ("N")</summary>
	public static readonly PermanentResidentStatusType N_NOTRESIDENT = new PermanentResidentStatusType("N");

	/// <summary>Temporary Resident ("T")</summary>
	public static readonly PermanentResidentStatusType T_TEMPORARY_RESIDENT = new PermanentResidentStatusType("T");

	/// <summary>Unknown ("99")</summary>
	public static readonly PermanentResidentStatusType C99_UNKNOWN = new PermanentResidentStatusType("99");

	///<summary>Wrap an arbitrary string value in a PermanentResidentStatusType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static PermanentResidentStatusType Wrap( String wrappedValue ) {
		return new PermanentResidentStatusType( wrappedValue );
	}

	private PermanentResidentStatusType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
